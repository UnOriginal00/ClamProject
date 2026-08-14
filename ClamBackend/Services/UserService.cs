using ClamBackend.Data;
using ClamBackend.Models;
using ClamBackend.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ClamBackend.Services
{
    public class UserService : IUserService
    {
        private readonly ClamDbContext _context;
        public UserService(ClamDbContext context) => _context = context;

        public async Task AddUserToDatabase(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetUser(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
