using MASProject.Server.Services.TourServices;
using MASProject.Shared.DTOs.UseCaseDTOs;
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
        public async Task<IActionResult> GetTours([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 8, [FromQuery] string? search = null, [FromQuery] string? startDate = null, [FromQuery] string? endDate = null)
        {
            GetAllToursDTO tours = await _tourService.GetTourDTOsAndToursCountAsync(pageNumber, pageSize, search, startDate, endDate);
            return Ok(tours);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUpdateTour(int id)
        {
            var tour = await _tourService.GetUpdateTourDTOAsync(id);
            return Ok(tour);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTour([FromBody] UpdateTourDTO tour)
        {
            await _tourService.UpdateTourAsync(tour);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTour(int id)
        {
            await _tourService.DeleteTourAsync(id);
            return Ok();
        }

    }
}
