using System.ComponentModel.DataAnnotations;

namespace ClamBackend.Models.DTOs
{
    public class UserCreateRequestDTO
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Password { get; set; }

    }
}
