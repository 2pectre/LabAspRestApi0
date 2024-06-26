using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;

namespace LabWinformApp
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void GetProductByIdButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(productIdTextBox.Text); // Assuming you have a TextBox for input
            var product = await GetProductByIdAsync(productId);
            if (product != null)
            {
                MessageBox.Show($"Product Name: {product.Name}, Price: {product.Price}");
            }
            else
            {
                MessageBox.Show("Product not found");
            }
        }

        private async Task<Product> GetProductByIdAsync(int id)
        {
            var response = await client.GetAsync($"http://localhost:8080/api/products/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>();
            }
            return null;
        }

        private async void GetProductsButton_Click(object sender, EventArgs e)
        {
            var products = await GetProductsAsync();
            dataGridView1.DataSource = products;
        }

        private async Task<List<Product>> GetProductsAsync()
        {
            return await client.GetFromJsonAsync<List<Product>>("http://localhost:8080/api/products");
        }

        private async void AddProductButton_Click(object sender, EventArgs e)
        {
            var newProduct = new Product { Id = 10, Name = "NewProduct", Price = 50.0m };
            var response = await client.PostAsJsonAsync("http://localhost:8080/api/products", newProduct);
            response.EnsureSuccessStatusCode();
        }

        private async void UpdateProductButton_Click(object sender, EventArgs e)
        {
            var updatedProduct = new Product { Id = 1, Name = "UpdatedProduct", Price = 60.0m };
            var response = await client.PutAsJsonAsync("http://localhost:8080/api/products/1", updatedProduct);
            response.EnsureSuccessStatusCode();
        }

        private async void DeleteProductButton_Click(object sender, EventArgs e)
        {
            var response = await client.DeleteAsync("http://localhost:8080/api/products/1");
            response.EnsureSuccessStatusCode();
        }

        // > --------------------------------------------------

        private async void PatchProductButton_Click(object sender, EventArgs e)
        {
            var updatedFields = new Product { Name = "PatchedProduct" };
            var response = await client.PatchAsJsonAsync("http://localhost:8080/api/products/1", updatedFields);
            response.EnsureSuccessStatusCode();
        }

        private async void OptionsButton_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Options, "http://localhost:8080/api/products");
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                if (response.Headers.TryGetValues("Allow", out IEnumerable<string> allowedMethods))
                {
                    MessageBox.Show($"Allowed Methods: {string.Join(", ", allowedMethods)}");
                }
                else
                {
                    MessageBox.Show("No Allow header found.");
                }
            }
            else
            {
                MessageBox.Show($"Request failed with status code: {response.StatusCode}");
            }
        }

        private async void HeadButton_Click(object sender, EventArgs e)
        {
            var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, "http://localhost:8080/api/products/1"));
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product exists.");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}