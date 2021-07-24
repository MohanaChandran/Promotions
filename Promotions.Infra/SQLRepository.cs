using Microsoft.EntityFrameworkCore;
using Propmotions.Core;
using Propmotions.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.Infra
{
    public class SQLRepository : IRepository
    {
        private readonly PromotionDBContext _dbContext;

        public SQLRepository(PromotionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetById<T>(int id) where T : BaseEntity
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> GetById<T>(int id, string include = null) where T : BaseEntity
        {
            return await _dbContext.Set<T>()
                .Include(include)
                .SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<ICollection<T>> GetAll<T>(ISpecification<T> spec = null) where T : BaseEntity
        {
            var query = _dbContext.Set<T>().AsQueryable();
           
            if (spec != null)
            {
                query = query.Where(spec.Criteria);
            }

            return await query.ToListAsync();
        }

        public async Task<ICollection<T>> GetAll<T>(Expression<Func<T, bool>> condition) where T : BaseEntity
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (condition != null)
            {
                query = query.Where(condition);
            }

            return await query.ToListAsync();
        }

        public async Task<T> Add<T>(T entity) where T : BaseEntity
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task Delete<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete<T>(int id) where T : BaseEntity
        {
            var entity = await _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> Update<T>(T entity, string[] includes = null) where T : BaseEntity
        {  

            var dbEntity = await _dbContext.FindAsync<T>(entity.Id);
            
            var dbEntry = _dbContext.Entry(dbEntity);
            
            dbEntry.CurrentValues.SetValues(entity);


            foreach (var propertyName in includes)
            {               
                var dbItemsEntry = dbEntry.Collection(propertyName);
                var accessor = dbItemsEntry.Metadata.GetCollectionAccessor();

                await dbItemsEntry.LoadAsync();
                var dbItemsMap = ((IEnumerable<BaseEntity>)dbItemsEntry.CurrentValue)
                    .ToDictionary(e => e.Id);

                var items = (IEnumerable<BaseEntity>)accessor.GetOrCreate(entity, true);

                foreach (var item in items)
                {
                    if (!dbItemsMap.TryGetValue(item.Id, out var oldItem))
                        accessor.Add(dbEntity, item, true);
                    else
                    {
                        _dbContext.Entry(oldItem).CurrentValues.SetValues(item);
                        dbItemsMap.Remove(item.Id);
                    }
                }

                foreach (var oldItem in dbItemsMap.Values)
                    accessor.Remove(dbEntity, oldItem);
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
