using Microsoft.EntityFrameworkCore;
using ClamProject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClamProject.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasIndex(u => u.UserName).IsUnique();
        }


    }
}
