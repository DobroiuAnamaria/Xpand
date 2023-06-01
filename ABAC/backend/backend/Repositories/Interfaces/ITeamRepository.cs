using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAllAsync();
        Task<int> AddAsync(Team captain);
    }
}
