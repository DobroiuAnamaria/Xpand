using backend.Services.Interfaces;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost]
        public async Task<ActionResult<TeamViewModel>> Add(TeamViewModel teamViewModel)
        {
            return Ok(await _teamService.AddTeamAsync(teamViewModel));
        }

        [HttpGet]
        public async Task<ActionResult<List<TeamViewModel>>> GetTeams()
        {
            return Ok(await _teamService.GetTeams());
        }
    }
}
