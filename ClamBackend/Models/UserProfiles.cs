namespace ClamProject.Models
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string DisplayName { get; set; } = null!;
        public string AvatarUrl { get; set; }
        public User User { get; set; } = null!;

    }
}
