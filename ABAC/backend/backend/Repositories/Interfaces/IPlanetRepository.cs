using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface IPlanetRepository
    {
        Task<List<Planet>> GetAllAsync();
        Task<Planet?> GetByIdAsync(int id);
        Task<int> AddAsync(Planet planet);
        Task<Planet> UpdateAsync(Planet planet);
    }
}
