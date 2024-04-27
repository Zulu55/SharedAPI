using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.API.Data;
using Shared.Common.Entities;

namespace Shared.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAsync(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest("The ids doesn't match.");
            }

            var currentUser = await _context.Users.FindAsync(id);
            if (currentUser == null)
            {
                return NotFound();
            }

            currentUser.Phone = user.Phone;
            currentUser.Email = user.Email;
            currentUser.FirstName = user.FirstName;
            currentUser.LastName = user.LastName;
            currentUser.Password = user.Password;

            _context.Users.Update(currentUser);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}