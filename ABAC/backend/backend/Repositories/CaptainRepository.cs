using backend.Entities;
using backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class CaptainRepository : ICaptainRepository
    {
        private readonly Context _context;

        public CaptainRepository(Context context)
        {
            _context = context;
        }

        public Task<List<Captain>> GetAllAsync()
        {
            return _context.Captains.ToListAsync();
        }

        public async Task<int> AddAsync(Captain robot)
        {
            _context.Captains.Add(robot);
            await _context.SaveChangesAsync();
            return robot.Id;
        }
    }
}
