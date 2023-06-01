using backend.ViewModels;

namespace backend.Services.Interfaces
{
    public interface ITeamService
    {
        Task<List<TeamViewModel>> GetTeams();
        Task<int> AddTeamAsync(TeamViewModel planet);
    }
}
