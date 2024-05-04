using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.API.Data;
using Shared.Common.Entities;



namespace Shared.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAsync(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("The ids doesn't match.");
            }

            var currentProduct = await _context.Products.FindAsync(id);
            if (currentProduct == null)
            {
                return NotFound();
            }

            currentProduct.Name = product.Name;
            currentProduct.Description = product.Description;
            currentProduct.Price = product.Price;
            currentProduct.Discount = product.Discount;

            _context.Products.Update(currentProduct);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
