using MASProject.Server.Services.TransportServices;
using Microsoft.AspNetCore.Mvc;

namespace MASProject.Server.Controllers
{
    /// <summary>
    /// API controller for managing transports.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransportsController : ControllerBase
    {
        private readonly ITransportService _transportService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportsController"/> class.
        /// </summary>
        /// <param name="transportService">The transport service.</param>
        public TransportsController(ITransportService transportService)
        {
            _transportService = transportService;
        }

        /// <summary>
        /// Gets a list of transports.
        /// </summary>
        /// <returns>An IActionResult containing the list of all transports available in the database.</returns>
        [HttpGet]
        public async Task<IActionResult> GetTransports()
        {
            return Ok(await _transportService.GetTransportDTOsAsync());
        }
    }
}
