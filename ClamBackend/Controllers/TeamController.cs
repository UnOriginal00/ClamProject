using ClamBackend.Services.Interfaces;
using ClamBackend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ClamBackend.Models.DTOs.TeamDTO;

namespace ClamBackend.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService) => _teamService = teamService;
        [HttpPost("create-team")]
        public async Task<ActionResult<Team>> AddTeamToDataBase(TeamCreateDTO team)
        {
            Team teams = new Team
            {
                Name = team.Name,
                TeamCreatedBy = team.CreatedBy
            };

            await _teamService.AddTeamToDataBase(teams);
            return Ok(teams);
        }

        //[HttpGet("access-team")]
    
    }
}
