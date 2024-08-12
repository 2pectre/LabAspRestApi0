using LabWinformApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LabWinformApp.Services
{
    public class ProductsService
    {
        private readonly HttpClient _client;

        public ProductsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var response = await _client.GetAsync($"http://localhost:8080/api/products/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>();
            }
            return null;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _client.GetFromJsonAsync<List<Product>>("http://localhost:8080/api/products");
        }

        public async Task AddProductAsync(Product product)
        {
            var response = await _client.PostAsJsonAsync("http://localhost:8080/api/products", product);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProductAsync(Product product)
        {
            var response = await _client.PutAsJsonAsync($"http://localhost:8080/api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProductAsync(int id)
        {
            var response = await _client.DeleteAsync($"http://localhost:8080/api/products/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task PatchProductAsync(int id, Product product)
        {
            var response = await _client.PatchAsJsonAsync($"http://localhost:8080/api/products/{id}", product);
            response.EnsureSuccessStatusCode();
        }

        public async Task<IEnumerable<string>> GetAllowedMethodsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Options, "http://localhost:8080/api/products");
            var response = await _client.SendAsync(request);
            if (response.IsSuccessStatusCode && response.Headers.TryGetValues("Allow", out IEnumerable<string> allowedMethods))
            {
                return allowedMethods;
            }
            return null;
        }

        public async Task<bool> ProductExistsAsync(int id)
        {
            var response = await _client.SendAsync(new HttpRequestMessage(HttpMethod.Head, $"http://localhost:8080/api/products/{id}"));
            return response.IsSuccessStatusCode;
        }
    }
}
