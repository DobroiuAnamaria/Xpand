using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface ICaptainRepository
    {
        Task<List<Captain>> GetAllAsync();
        Task<int> AddAsync(Captain captain);
    }
}
