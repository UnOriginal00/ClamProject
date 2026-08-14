using ClamBackend.Data;
using ClamBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ClamBackend.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUserToDatabase(User user);
        Task<User?> GetUser(Guid id);

    }
}
