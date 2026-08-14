using ClamBackend.Models;

namespace ClamBackend.Services.Interfaces
{
    public interface ITeamService
    {
        Task AddTeamToDataBase(Team team);
        Task GetTeam(Guid guid);
        Task DeleteTeamFromDatabase();
        Task ModifyTeamName();
        Task ModifyTeamDescription();
        Task ModifyTeamProfilePicture();
    }
}
