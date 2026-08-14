namespace ClamBackend.Models.DTOs.TeamDTO
{
    public class TeamCreateDTO
    {
        public string Name { get; set; }
        public Guid CreatedBy {  get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
