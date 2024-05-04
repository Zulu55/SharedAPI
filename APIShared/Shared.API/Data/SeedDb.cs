using Shared.Common.Entities;

namespace Shared.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProductsAsync();
        }

        private async Task CheckProductsAsync()
        {
            if (!_context.Products.Any()) {
                _context.Products.Add(new Product { Name = "jacket", Description = "jacket of leather", Price = 1000, Discount = 10 });
                _context.Products.Add(new Product { Name = "shoes", Description = "multiple sizes", Price = 1000, Discount = 12 });
                _context.Products.Add(new Product { Name = "skirt", Description = "multiple sizes and colors", Price = 80, Discount = 9 });
                _context.Products.Add(new Product { Name = "cap", Description = "multiple styles", Price = 80, Discount = 1 });
                await _context.SaveChangesAsync();
            }
        }
    }
}
