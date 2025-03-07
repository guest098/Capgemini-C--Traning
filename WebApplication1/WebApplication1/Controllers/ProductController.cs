using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _context.Products.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();
            return product;
        }
        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null) return NotFound();

            existingProduct.ProductName = product.ProductName;
            existingProduct.ProductDescription = product.ProductDescription;
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;

            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
