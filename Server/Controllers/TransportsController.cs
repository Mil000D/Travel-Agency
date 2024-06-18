using MASProject.Server.Services.TransportServices;
using Microsoft.AspNetCore.Mvc;

namespace MASProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportsController : ControllerBase
    {
        private readonly ITransportService _transportService;
        public TransportsController(ITransportService transportService)
        {
            _transportService = transportService;
        }
        [HttpGet]
        public async Task<IActionResult> GetTransports()
        {
            return Ok(await _transportService.GetTransportsAsync());
        }
    }
}
