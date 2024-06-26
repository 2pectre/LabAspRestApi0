using Microsoft.AspNetCore.Mvc;
using LabAspApi.Models;
using System.Collections.Generic;

namespace LabAspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 10.0m },
            new Product { Id = 2, Name = "Product2", Price = 20.0m },
            new Product { Id = 333, Name = "Product3", Price = 123.0m },
            new Product { Id = 4444, Name = "Product4", Price = 456.0m },
            new Product { Id = 55555, Name = "Product5", Price = 9999.0m },
            new Product { Id = 9, Name = "Test", Price = 987654.0m }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products.Remove(product);
            return NoContent();
        }

        // > --------------------------------------------------

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] Product updatedFields)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(updatedFields.Name))
            {
                existingProduct.Name = updatedFields.Name;
            }

            if (updatedFields.Price != default)
            {
                existingProduct.Price = updatedFields.Price;
            }

            return NoContent();
        }

        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET,POST,PUT,PATCH,DELETE,OPTIONS,HEAD");
            return Ok();
        }

        [HttpHead("{id}")]
        public IActionResult Head(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}