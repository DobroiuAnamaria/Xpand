using AutoMapper;
using backend.Entities;
using backend.Repositories.Interfaces;
using backend.Services.Interfaces;
using backend.ViewModels;

namespace backend.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;
        private readonly IMapper _mapper;


        public PlanetService(IPlanetRepository planetRepository, IMapper mapper)
        {
            _planetRepository = planetRepository;
            _mapper = mapper;
        }
        public async Task<int> AddPlanetAsync(PlanetViewModel planet)
        {
            return await _planetRepository.AddAsync(_mapper.Map<Planet>(planet));
        }

        public async Task<List<PlanetViewModel>> GetPlanets()
        {
            var planets = await _planetRepository.GetAllAsync();
            return _mapper.Map<List<PlanetViewModel>>(planets);
        }

        public async Task<UpdatePlanetViewModel> UpdatePlanet(UpdatePlanetViewModel planetViewModel)
        {
            var actualPlanet = await _planetRepository.GetByIdAsync(planetViewModel.Id);
            if (actualPlanet == null)
            {
                throw new Exception("There is no planet with such ID");
            }
            actualPlanet.Name = planetViewModel.Name;
            actualPlanet.Description = planetViewModel.Description;
            actualPlanet.PlanetStatus = planetViewModel.PlanetStatus;
            actualPlanet.TeamId = planetViewModel.TeamId;
            await _planetRepository.UpdateAsync(actualPlanet);
            return _mapper.Map<UpdatePlanetViewModel>(actualPlanet);
        }
    }
}
