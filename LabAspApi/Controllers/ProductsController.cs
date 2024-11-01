using Microsoft.AspNetCore.Mvc;
using LabAspApi.Models;
using LabAspApi.Services;
using System.Collections.Generic;

namespace LabAspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_productsService.GetAllProducts());
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _productsService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            _productsService.AddProduct(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            if (!_productsService.UpdateProduct(id, product))
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_productsService.DeleteProduct(id))
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] Product updatedFields)
        {
            if (!_productsService.PatchProduct(id, updatedFields))
            {
                return NotFound();
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
            var product = _productsService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}