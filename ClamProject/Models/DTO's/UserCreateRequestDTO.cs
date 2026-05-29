using System.ComponentModel.DataAnnotations;

namespace ClamProject.Models.DTO_s
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
