using AutoMapper;
using backend.Entities;
using backend.Repositories.Interfaces;
using backend.Services.Interfaces;
using backend.ViewModels;

namespace backend.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;


        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public async Task<int> AddTeamAsync(TeamViewModel team)
        {
            return await _teamRepository.AddAsync(_mapper.Map<Team>(team));
        }

        public async Task<List<TeamViewModel>> GetTeams()
        {
            var teams = await _teamRepository.GetAllAsync();
            return _mapper.Map<List<TeamViewModel>>(teams);
        }
    }
}
