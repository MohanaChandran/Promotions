using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Propmotions.Core.Interface
{
    public interface IRepository
    {
        Task<T> GetById<T>(int id) where T : BaseEntity;
        Task<T> GetById<T>(int id, string include) where T : BaseEntity;
        Task<ICollection<T>> GetAll<T>(ISpecification<T> spec = null) where T : BaseEntity;
        Task<ICollection<T>> GetAll<T>(Expression<Func<T, bool>> condition) where T : BaseEntity;
        Task<T> Add<T>(T entity) where T : BaseEntity;
        Task<T> Update<T>(T entity,string[] includes = null) where T : BaseEntity;
        Task Delete<T>(T entity) where T : BaseEntity;
        Task Delete<T>(int id) where T : BaseEntity;
    }
}
