using MASProject.Server.Services.LodgingServices;
using Microsoft.AspNetCore.Mvc;

namespace MASProject.Server.Controllers
{
    /// <summary>
    /// API controller for managing lodgings.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LodgingsController : ControllerBase
    {
        private readonly ILodgingService _lodgingService;

        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingsController"/> class.
        /// </summary>
        /// <param name="lodgingService">The lodging service.</param>
        public LodgingsController(ILodgingService lodgingService)
        {
            _lodgingService = lodgingService;
        }

        /// <summary>
        /// Gets a list of lodgings.
        /// </summary>
        /// <returns>An IActionResult containing the list of all lodgings available in database.</returns>
        [HttpGet]
        public async Task<IActionResult> GetLodgings()
        {
            return Ok(await _lodgingService.GetLodgingDTOsAsync());
        }
    }
}
