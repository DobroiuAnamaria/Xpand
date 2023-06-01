using backend.Entities;
using backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly Context _context;

        public TeamRepository(Context context)
        {
            _context = context;
        }

        public Task<List<Team>> GetAllAsync()
        {
            return _context.Teams
                .Include(t => t.Captain)
                .Include(t => t.Robots)
                .ToListAsync();
        }

        public async Task<int> AddAsync(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team.Id;
        }
    }
}
