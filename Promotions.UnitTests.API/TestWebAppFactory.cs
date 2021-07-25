using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Promotions.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotions.UnitTests.API
{
    public class TestWebApplicationFactory<TStartup> : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Create a new service provider.
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();

                // Add a database context (AppDbContext) using an in-memory
                // database for testing.
                services.AddDbContext<PromotionDBContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                    options.UseInternalServiceProvider(serviceProvider);
                });
               

                // Build the service provider.
                var sp = services.BuildServiceProvider();

                // Create a scope to obtain a reference to the database                
                using(var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<PromotionDBContext>();

                    var logger = scopedServices
                        .GetRequiredService<ILogger<TestWebApplicationFactory<TStartup>>>();

                    // Ensure the database is created.
                    db.Database.EnsureCreated();

                    try
                    {
                        // Seed the database with test data.
                        PopulateTestData(db);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "An error occurred seeding the " +
                            "database with test messages. Error: {ex.Message}");
                    }
                }
            });
        }

        public static void PopulateTestData(PromotionDBContext dbContext)
        {
            foreach (var item in dbContext.Keyword)
            {
                dbContext.Remove(item);
            }

            dbContext.SaveChanges();
            dbContext.Keyword.Add(new KeywordsBuilder().Name("Test").Description("Test").Build());
            dbContext.Keyword.Add(new KeywordsBuilder().WithDefaultValues().Build());
            dbContext.Keyword.Add(new KeywordsBuilder().WithId().Build());
            dbContext.Keyword.Add(new KeywordsBuilder().WithDefaultValuesAndDocuments().Build());
            dbContext.SaveChanges();
        }
    }
}
