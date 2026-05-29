using ClamProject.Data;
using ClamProject.Models;


namespace ClamProject.Services
{
    public class UserServices(ClamDbContext context)
    {

        private readonly ClamDbContext _context = context;

       public void AddUserToDatabase(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

    }
}
