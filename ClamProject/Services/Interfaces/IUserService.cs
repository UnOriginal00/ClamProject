using ClamProject.Data;
using ClamProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ClamProject.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUserToDatabase(User user);
        Task<User?> GetUser(Guid id);

    }
}
