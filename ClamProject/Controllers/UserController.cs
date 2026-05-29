using ClamProject.Data;
using ClamProject.Models;
using ClamProject.Models.DTO_s;
using ClamProject.Services;
using ClamProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClamProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Using an interface for abstraction and unit testing ( Idk if this is over engineering yet )
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _services = userService;

        //Adding new user to db via DTO
        [HttpPost("register")]
        public async Task<ActionResult<User>> CreateUser(UserCreateRequestDTO register) {
            //Required User Info for adding to db
            User user = new User{

                UserName = register.UserName,
                PasswordHash = register.Password,
                Email = register.Email

                };
            _ = new PasswordHasher<User>()
                .HashPassword(user, register.Password);


            if (register is null)
                return BadRequest("Please input proper user info");

            await _services.AddUserToDatabase(user);

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(UserLoginDTO request)
        {
            User user = new();

            if (request == null) 
                return BadRequest();

            if (user.PasswordHash != request.Password || user.Email != request.Email)
                return BadRequest("Email or Password was incorrect.");

            return Ok(user);
        }

        //Sending User data to API caller via id in URL
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id) {

            if(id == null)
                return NotFound();

            User user = await _services.GetUser(id);

            return Ok(user);
        }

    }
    
}
