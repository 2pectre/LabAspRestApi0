using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using LabWinformApp.Models;

namespace LabWinformApp.Services
{
    public class TestService
    {
        private readonly HttpClient _client;

        public TestService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<TestEntity>> GetTestsAsync()
        {
            return await _client.GetFromJsonAsync<IEnumerable<TestEntity>>("http://localhost:8080/api/test");
        }

        public async Task<TestEntity> GetTestAsync(int id)
        {
            return await _client.GetFromJsonAsync<TestEntity>($"http://localhost:8080/api/test/{id}");
        }

        public async Task<bool> CreateTestAsync(TestEntity testEntity)
        {
            var response = await _client.PostAsJsonAsync("http://localhost:8080/api/test", testEntity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateTestAsync(int id, string newTestValue)
        {
            var response = await _client.PatchAsJsonAsync($"http://localhost:8080/api/test/{id}", newTestValue);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteTestAsync(int id)
        {
            var response = await _client.DeleteAsync($"http://localhost:8080/api/test/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
