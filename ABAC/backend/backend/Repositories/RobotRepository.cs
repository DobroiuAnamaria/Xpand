using backend.Entities;
using backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class RobotRepository : IRobotRepository
    {
        private readonly Context _context;

        public RobotRepository(Context context)
        {
            _context = context;
        }

        public Task<List<Robot>> GetAllAsync()
        {
            return _context.Robots.ToListAsync();
        }

        public async Task<int> AddAsync(Robot robot)
        {
            _context.Robots.Add(robot);
            await _context.SaveChangesAsync();
            return robot.Id;
        }
    }
}
