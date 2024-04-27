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
            await CheckUsersAsync();
        }

        private async Task CheckUsersAsync()
        {
            if (!_context.Users.Any())
            {
                _context.Users.Add(new User { Email = "zulu@yopmail.com", FirstName = "Juan", LastName = "Zuluaga", Password = "123456", Phone = "322 311 4620" });
                _context.Users.Add(new User { Email = "ledys@yopmail.com", FirstName = "Ledys", LastName = "Bedoya", Password = "123456", Phone = "322 311 4620" });
                _context.Users.Add(new User { Email = "benedict@yopmail.com", FirstName = "Benedict", LastName = "Zuluaga", Password = "123456", Phone = "322 311 4620" });
                _context.Users.Add(new User { Email = "isis@yopmail.com", FirstName = "Isis", LastName = "Zuluaga", Password = "123456", Phone = "322 311 4620" });
                await _context.SaveChangesAsync();
            }
        }
    }
}