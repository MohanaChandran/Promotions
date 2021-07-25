using Propmotions.Core;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Promotions.UnitTests
{
    public class KeywordsTests: BaseEfRepoTestFixture
    {
        [Fact]
        public async Task Keyword_with_name_success()
        {

            var repository = GetRepository();
            var item = new KeywordsBuilder().Name("Test").Build();
            await repository.Add(item);
            var newItem = await repository.GetAll<Keyword>();
            Assert.Equal(item, newItem.FirstOrDefault());
            Assert.True(newItem.FirstOrDefault()?.Id > 0);
        }

        [Fact]
        public async Task Keyword_with_description_success()
        {
            var repository = GetRepository();
            var item = new KeywordsBuilder().Name("Test").Description("Test").Build();
            await repository.Add(item);
            var newItem = await repository.GetAll<Keyword>();
            Assert.Equal(item, newItem.FirstOrDefault());
            Assert.True(newItem.FirstOrDefault()?.Id > 0);
        }

        [Fact]
        public async Task Keyword_with_documents_success()
        {
            var repository = GetRepository();
            var item = new KeywordsBuilder().WithDefaultValuesAndDocuments().Build();
            await repository.Add(item);
            var newItem = await repository.GetAll<Keyword>();
            Assert.Equal(item, newItem.FirstOrDefault());
            Assert.True(newItem.FirstOrDefault()?.Id > 0);
        }
    }
}
