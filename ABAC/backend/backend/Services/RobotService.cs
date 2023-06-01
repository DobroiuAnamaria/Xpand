using AutoMapper;
using backend.Entities;
using backend.Repositories.Interfaces;
using backend.Services.Interfaces;
using backend.ViewModels;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace backend.Services
{
    public class RobotService : IRobotService
    {
        private readonly IRobotRepository _robotRepository;
        private readonly IMapper _mapper;


        public RobotService(IRobotRepository robotRepository, IMapper mapper)
        {
            _robotRepository = robotRepository;
            _mapper = mapper;
        }
        public async Task<int> AddRobotAsync(RobotViewModel robot)
        {
            return await _robotRepository.AddAsync(_mapper.Map<Robot>(robot));
        }

        public async Task<List<RobotViewModel>> GetRobots()
        {
            var robots = await _robotRepository.GetAllAsync();
            return _mapper.Map<List<RobotViewModel>>(robots);
        }
    }
}
