using ClamBackend.Data;
using ClamBackend.Models;
using ClamBackend.Models.DTOs;
using ClamBackend.Services;
using ClamBackend.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace ClamBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Using an interface for abstraction and unit testing ( Idk if this is over engineering yet )
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService) => _userService = userService;

        //Adding new user to db via DTO
        
        [HttpPost("register")]
        public async Task<ActionResult<User>> CreateUser(UserCreateRequestDTO register) {
            //Required User Info for adding to db
            User user = new User{

                UserName = register.UserName,
                Email = register.Email

                };
            user.PasswordHash = new PasswordHasher<User>()
                .HashPassword(user, register.Password);


            if (register is null)
                return BadRequest("Please input proper user info");

            await _userService.AddUserToDatabase(user);

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

            //If user authentication was verified
            

            return Ok(user);
        }

        //Sending User data to API caller via id in URL
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id) {

            if(id == null)
                return NotFound();

            User user = await _userService.GetUser(id);

            return Ok(user);
        }

    }
    
}
