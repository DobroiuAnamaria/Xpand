using backend.Services.Interfaces;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/robots")]
    public class RobotController : ControllerBase
    {
        private readonly IRobotService _robotService;

        public RobotController(IRobotService robotService)
        {
            _robotService = robotService;
        }

        [HttpPost]
        public async Task<ActionResult<RobotViewModel>> Add(RobotViewModel robotViewModel)
        {
            return Ok(await _robotService.AddRobotAsync(robotViewModel));
        }

        [HttpGet]
        public async Task<ActionResult<List<RobotViewModel>>> GetRobots()
        {
            return Ok(await _robotService.GetRobots());
        }
    }
}
