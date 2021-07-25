using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Promotions.UnitTests.API
{
    public class KeywordsAPITests : IClassFixture<TestWebApplicationFactory<Startup>>
    {

        private readonly HttpClient _client;

        public KeywordsAPITests(TestWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Keyword_create_name_missing_error()
        {
            var data = new KeywordsBuilder().Description("Test").Build();

            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"/api/keywords", jsonContent);
            
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
          
        }

        [Fact]
        public async Task Keyword_create_name_maxlen_error()
        {
            var data = new KeywordsBuilder().Name("123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890").Build();

            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"/api/keywords", jsonContent);           

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_create_withoutdocs_success()
        {
            var data = new KeywordsBuilder().WithDefaultValues().Build();

            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"/api/keywords", jsonContent);           
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_create_withdocs_success()
        {
            var data = new KeywordsBuilder().WithDefaultValuesAndDocuments().Build();

            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"/api/keywords", jsonContent);           

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_get_by_id_success()
        {
            var id = 100;

            var response = await _client.GetAsync($"/api/keywords/" + id);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_get_by_id_failure()
        {
            var id = 30000;

            var response = await _client.GetAsync($"/api/keywords/" + id);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_get_by_name_success()
        {
            var name = "Test";

            var response = await _client.GetAsync($"/api/keywords?name=" + name);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }


        [Fact]
        public async Task Keyword_update_name_missing_error()
        {
            var data = new KeywordsBuilder().Description("Test").Build();

            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"/api/keywords", jsonContent);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_update_name_maxlen_error()
        {
            var data = new KeywordsBuilder().Name("123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890").Build();

            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"/api/keywords", jsonContent);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_update_withoutdocs_success()
        {
            var data = new KeywordsBuilder().WithId().Build();
          
            var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"/api/keywords", jsonContent);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task Keyword_update_withdocs_success()
        {
            var data = new KeywordsBuilder().WithId().WithDocuments().Build();
           var jsonContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"/api/keywords", jsonContent);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

    }
}
