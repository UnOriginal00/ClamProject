using ClamBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ClamBackend.Data
{
    public class ClamDbContext : DbContext
    {
        public ClamDbContext(DbContextOptions<ClamDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClamDbContext).Assembly);
        }
    }
}
