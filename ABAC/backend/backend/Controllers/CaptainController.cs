using backend.Services.Interfaces;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/captains")]
    public class CaptainController : ControllerBase
    {
        private readonly ICaptainService _robotService;

        public CaptainController(ICaptainService robotService)
        {
            _robotService = robotService;
        }

        [HttpPost]
        public async Task<ActionResult<CaptainViewModel>> Add(CaptainViewModel robotViewModel)
        {
            return Ok(await _robotService.AddCaptainAsync(robotViewModel));
        }

        [HttpGet]
        public async Task<ActionResult<List<CaptainViewModel>>> GetCaptains()
        {
            return Ok(await _robotService.GetCaptains());
        }
    }
}
