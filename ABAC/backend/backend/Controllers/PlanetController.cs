using backend.Services.Interfaces;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/planets")]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetService _planetService;

        public PlanetController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [HttpPost]
        public async Task<ActionResult<PlanetViewModel>> Add(PlanetViewModel planetViewModel)
        {
            return Ok(await _planetService.AddPlanetAsync(planetViewModel));
        }

        [HttpGet]
        public async Task<ActionResult<List<PlanetViewModel>>> GetPlanets()
        {
            return Ok(await _planetService.GetPlanets());
        }

        [HttpPut]
        public async Task<ActionResult<UpdatePlanetViewModel>> UpdatePlanet([FromBody] UpdatePlanetViewModel planetViewModel)
        {
            return Ok(await _planetService.UpdatePlanet(planetViewModel));
        }
    }
}
