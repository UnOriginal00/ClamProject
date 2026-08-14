using ClamBackend.Services.Interfaces;
using ClamBackend.Data;
using ClamBackend.Models;

namespace ClamBackend.Services
{
    public class TeamService : ITeamService
    {
        private readonly ClamDbContext _context;
        public TeamService(ClamDbContext context) => _context = context;

        public async Task AddTeamToDataBase(Team team)
        {
            _context.Add(team);
            await _context.SaveChangesAsync();
        }

        public async Task GetTeam(Guid guid)
        {
            await _context.Teams.FindAsync(guid);
        }

        public Task DeleteTeamFromDatabase()
        {
            throw new NotImplementedException();
        }

        public Task ModifyTeamDescription()
        {
            throw new NotImplementedException();
        }

        public Task ModifyTeamName()
        {
            throw new NotImplementedException();
        }

        public Task ModifyTeamProfilePicture()
        {
            throw new NotImplementedException();
        }
    }
}
