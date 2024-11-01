using LabAspApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace LabAspApi.Services
{
    public class ProductsService
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 10.0m },
            new Product { Id = 2, Name = "Product2", Price = 20.0m },
            new Product { Id = 333, Name = "Product3", Price = 123.0m },
            new Product { Id = 4444, Name = "Product4", Price = 456.0m },
            new Product { Id = 55555, Name = "Product5", Price = 9999.0m },
            new Product { Id = 9, Name = "Test", Price = 987654.0m }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public bool UpdateProduct(int id, Product updatedProduct)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null) return false;

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Price = updatedProduct.Price;
            return true;
        }

        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;

            _products.Remove(product);
            return true;
        }

        public bool PatchProduct(int id, Product updatedFields)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null) return false;

            if (!string.IsNullOrEmpty(updatedFields.Name))
            {
                existingProduct.Name = updatedFields.Name;
            }

            if (updatedFields.Price != default)
            {
                existingProduct.Price = updatedFields.Price;
            }

            return true;
        }
    }
}