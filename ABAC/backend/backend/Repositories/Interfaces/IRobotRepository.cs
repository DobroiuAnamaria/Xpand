using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface IRobotRepository
    {
        Task<List<Robot>> GetAllAsync();
        Task<int> AddAsync(Robot robot);
    }
}
