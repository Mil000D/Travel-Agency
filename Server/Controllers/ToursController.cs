using MASProject.Server.Services.TourServices;
using Microsoft.AspNetCore.Mvc;

namespace MASProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly ITourService _tourService;
        public ToursController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTours([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 8)
        {
            var tours = await _tourService.GetToursAsync(pageNumber, pageSize);
            return Ok(tours);
        }
        [HttpGet("count")]
        public async Task<IActionResult> GetToursCount()
        {
            var count = await _tourService.GetToursCountAsync();
            return Ok(count);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUpdateTour(int id)
        {
            var tour = await _tourService.GetUpdateTourAsync(id);
            return Ok(tour);
        }
    }
}
