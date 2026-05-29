using ClamProject.Data;
using ClamProject.Models;
using ClamProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime.CompilerServices;


namespace ClamProject.Services
{
    public class UserService(ClamDbContext context) : IUserService
    {

       private readonly ClamDbContext _context = context;

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
