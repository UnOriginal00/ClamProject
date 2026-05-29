using ClamProject.Data;
using ClamProject.Models;
using ClamProject.Models.DTO_s;
using ClamProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClamProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserServices services) : ControllerBase
    {
        private readonly UserServices _services = services;


        [HttpPost("createnewuser")]
        public ActionResult<User> CreateUser(UserCreateRequestDTO register) {

            User user = new User{

                UserName = register.UserName,
                PasswordHash = register.Password,
                Email = register.Email

                };

            if (register is null)
                return BadRequest("Please input proper user info");



            _services.AddUserToDatabase(user);

            return Ok(user);
        }

    }
    
}
