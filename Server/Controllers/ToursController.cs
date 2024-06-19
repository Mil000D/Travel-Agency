using MASProject.Server.Services.TourServices;
using MASProject.Shared.DTOs.TourDTOs;
using Microsoft.AspNetCore.Mvc;

namespace MASProject.Server.Controllers
{
    /// <summary>
    /// API controller for managing tours.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly ITourService _tourService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToursController"/> class.
        /// </summary>
        /// <param name="tourService">The tour service.</param>
        public ToursController(ITourService tourService)
        {
            _tourService = tourService;
        }

        /// <summary>
        /// Gets a paginated list of tours with optional search and date filters.
        /// </summary>
        /// <param name="pageNumber">The page number for pagination.</param>
        /// <param name="pageSize">The number of tours per page.</param>
        /// <param name="search">Optional search parameter.</param>
        /// <param name="startDate">Optional start date filter.</param>
        /// <param name="endDate">Optional end date filter.</param>
        /// <returns>An IActionResult containing the list of tours and the total count.</returns>
        [HttpGet]
        public async Task<IActionResult> GetTours([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 8, [FromQuery] string? search = null, [FromQuery] string? startDate = null, [FromQuery] string? endDate = null)
        {
            GetAllToursDTO tours = await _tourService.GetTourDTOsAndToursCountAsync(pageNumber, pageSize, search, startDate, endDate);
            return Ok(tours);
        }

        /// <summary>
        /// Gets the details of a specific tour chosen to update.
        /// </summary>
        /// <param name="id">The ID of the tour to retrieve.</param>
        /// <returns>An IActionResult containing the tour details.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUpdateTour(int id)
        {
            var tour = await _tourService.GetUpdateTourDTOAsync(id);
            return Ok(tour);
        }

        /// <summary>
        /// Updates the details of a specific tour.
        /// </summary>
        /// <param name="tour">The updated tour details.</param>
        /// <returns>An IActionResult indicating the result of the update operation.</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateTour([FromBody] UpdateTourDTO tour)
        {
            await _tourService.UpdateTourAsync(tour);
            return Ok();
        }

        /// <summary>
        /// Deletes a specific tour.
        /// </summary>
        /// <param name="id">The ID of the tour to delete.</param>
        /// <returns>An IActionResult indicating the result of the delete operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTour(int id)
        {
            await _tourService.DeleteTourAsync(id);
            return Ok();
        }

    }
}
