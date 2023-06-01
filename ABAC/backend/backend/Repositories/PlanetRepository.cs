using backend.Entities;
using backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly Context _context;

        public PlanetRepository(Context context)
        {
            _context = context;
        }

        public Task<List<Planet>> GetAllAsync()
        {
            return _context.Planets.Include(p => p.Team)
                                        .ThenInclude(t => t.Captain)
                                    .Include(p => p.Team)
                                        .ThenInclude(t => t.Robots)
                                   .ToListAsync();
        }

        public Task<Planet?> GetByIdAsync(int id)
        {
            return _context.Planets.Include(p => p.Team)
                            .ThenInclude(t => t.Captain)
                        .Include(p => p.Team)
                            .ThenInclude(t => t.Robots)
                       .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> AddAsync(Planet planet)
        {
            _context.Planets.Add(planet);
            await _context.SaveChangesAsync();
            return planet.Id;
        }

        public async Task<Planet> UpdateAsync(Planet planet)
        {
            _context.Planets.Update(planet);
            await _context.SaveChangesAsync();
            return planet;
        }
    }
}
