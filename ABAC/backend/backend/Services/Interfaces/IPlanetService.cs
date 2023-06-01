using backend.ViewModels;

namespace backend.Services.Interfaces
{
    public interface IPlanetService
    {
        Task<List<PlanetViewModel>> GetPlanets();
        Task<int> AddPlanetAsync(PlanetViewModel planet);
        Task<UpdatePlanetViewModel> UpdatePlanet(UpdatePlanetViewModel planet);

    }
}
