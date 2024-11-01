using LabWinformApp.Models;
using LabWinformApp.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LabWinformApp
{
    public partial class Form1 : Form
    {
        private readonly TestService _testService;
        private readonly ProductsService _productsService;

        public Form1()
        {
            InitializeComponent();
            _testService = new TestService(Program.HttpClient);
            _productsService = new ProductsService(Program.HttpClient);
        }

        private async void btnGetTestById_Click(object sender, EventArgs e)
        {
            if (txtTestId.Text.Length == 0)
                return;

            try
            {
                int testId = int.Parse(txtTestId.Text);
                var test = await _testService.GetTestAsync(testId);
                if (test != null)
                {
                    MessageBox.Show($"Test ID: {test.Id}, Test: {test.Test}");
                }
                else
                {
                    MessageBox.Show("Test not found");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format. Please enter a valid number.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An error occurred while retrieving the test. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private async void btnGetTests_Click(object sender, EventArgs e)
        {
            try
            {
                var tests = await _testService.GetTestsAsync();
                dgvTest.DataSource = tests;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format. Please enter a valid number.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An error occurred while retrieving the test. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private async void btnCreateTest_Click(object sender, EventArgs e)
        {
            if (txtCreateTest.Text.Length == 0)
            {
                MessageBox.Show("비어있음");
                return;
            }

            var newTest = new TestEntity { Test = txtCreateTest.Text };
            var success = await _testService.CreateTestAsync(newTest);
            MessageBox.Show(success ? "Test created successfully" : "Failed to create test");
        }

        private async void btnUpdateTest_Click(object sender, EventArgs e)
        {
            int testId = int.Parse(txtTestId.Text);
            var success = await _testService.UpdateTestAsync(testId, "Updated Test Value");
            MessageBox.Show(success ? "Test updated successfully" : "Failed to update test");
        }

        private async void btnDeleteTest_Click(object sender, EventArgs e)
        {
            int testId = int.Parse(txtTestId.Text);
            var success = await _testService.DeleteTestAsync(testId);
            MessageBox.Show(success ? "Test deleted successfully" : "Failed to delete test");
        }

        // > ################################################## : Product
        private async void btnGetProductById_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text.Length == 0)
                return;

            int productId = int.Parse(txtProductId.Text);
            var product = await _productsService.GetProductByIdAsync(productId);
            if (product != null)
            {
                MessageBox.Show($"Product Name: {product.Name}, Price: {product.Price}");
            }
            else
            {
                MessageBox.Show("Product not found");
            }
        }

        private async void btnGetProducts_Click(object sender, EventArgs e)
        {
            var products = await _productsService.GetProductsAsync();
            dgvProduct.DataSource = products;
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            var newProduct = new Product { Id = 10, Name = "NewProduct", Price = 50.0m };
            try
            {
                await _productsService.AddProductAsync(newProduct);
                MessageBox.Show("Product added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add product: {ex.Message}");
            }
        }

        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            var updatedProduct = new Product { Id = 1, Name = "UpdatedProduct", Price = 60.0m };
            try
            {
                await _productsService.UpdateProductAsync(updatedProduct);
                MessageBox.Show("Product updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update product: {ex.Message}");
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                await _productsService.DeleteProductAsync(1);
                MessageBox.Show("Product deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete product: {ex.Message}");
            }
        }

        private async void btnPatchProduct_Click(object sender, EventArgs e)
        {
            var updatedFields = new Product { Name = "PatchedProduct" };
            try
            {
                await _productsService.PatchProductAsync(1, updatedFields);
                MessageBox.Show("Product patched successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to patch product: {ex.Message}");
            }
        }

        private async void btnOptions_Click(object sender, EventArgs e)
        {
            var allowedMethods = await _productsService.GetAllowedMethodsAsync();
            MessageBox.Show($"Allowed Methods: {string.Join(", ", allowedMethods)}");
        }

        private async void btnHead_Click(object sender, EventArgs e)
        {
            var exists = await _productsService.ProductExistsAsync(1);
            if (exists)
            {
                MessageBox.Show("Product exists.");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
    }
}
