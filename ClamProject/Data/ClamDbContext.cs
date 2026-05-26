using ClamProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ClamProject.Data
{
    public class ClamDbContext(DbContextOptions<ClamDbContext> options) : DbContext(options)
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


    }
}
