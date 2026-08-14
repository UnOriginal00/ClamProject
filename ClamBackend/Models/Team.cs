namespace ClamBackend.Models
{
    public class Team
    {
        public Guid TeamID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid TeamCreatedBy { get; set;  }
        public DateTime? CreatedAt { get; set; }
    }
}
