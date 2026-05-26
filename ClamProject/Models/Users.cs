namespace ClamProject.Models
{
    public class User
    {
        Guid Id { get; set; }
        string UserName { get; set; } = null!;
        string Email { get; set; } = null!;
        string PasswordHash { get; set; } = null!;
        DateTime CreatedAt { get; set; } = DateTime.Now;
        UserProfile Profile { get; set; } = null!;
    }
}
