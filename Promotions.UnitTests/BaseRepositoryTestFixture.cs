using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.DependencyInjection;
using Promotions.Infra;
using Propmotions.Core;

namespace Promotions.UnitTests
{
    public abstract class BaseEfRepoTestFixture
    {
        protected PromotionDBContext _dbContext;

        protected static DbContextOptions<PromotionDBContext> CreateNewContextOptions()
        { 
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();
            
            var builder = new DbContextOptionsBuilder<PromotionDBContext>();
            builder.UseInMemoryDatabase("promotion")
                   .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }

        protected SQLRepository GetRepository()
        {
            var options = CreateNewContextOptions();
            _dbContext = new PromotionDBContext(options);
            return new SQLRepository(_dbContext);
        }


    }
}
