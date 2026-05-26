namespace ClamProject.Models
{
    public class UserProfile
    {
        Guid Id { get; set; }
        Guid UserId { get; set; } = Guid.NewGuid();
        string DisplayName { get; set; } = null!;
        string AvatarUrl { get; set; }
        User User { get; set; } = null!;

    }
}
