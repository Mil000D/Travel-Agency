using MASProject.Server.Services.LodgingServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MASProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LodgingsController : ControllerBase
    {
        private readonly ILodgingService _lodgingService;
        public LodgingsController(ILodgingService lodgingService)
        {
            _lodgingService = lodgingService;
        }
        [HttpGet]
        public async Task<IActionResult> GetLodgings()
        {
            return Ok(await _lodgingService.GetLodgingsAsync());
        }
    }
}
