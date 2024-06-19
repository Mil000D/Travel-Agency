using MASProject.Server.Models.TourModels;
using MASProject.Shared.DTOs.TourDTOs;

namespace MASProject.Server.Services.TourServices
{
    /// <summary>
    /// Interface for tour services.
    /// </summary>
    public interface ITourService
    {
        /// <summary>
        /// Asynchronously deletes a tour by specified ID.
        /// </summary>
        /// <param name="id">The ID of the tour chosen to delete.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteTourAsync(int id);
        
        /// <summary>
        /// Asynchronously retrieves a tour DTO by its ID.
        /// </summary>
        /// <param name="id">The ID of the tour to retrieve from database.</param>
        /// <returns>A Task representing the asynchronous operation, with a GetTourDTO as the result.</returns>
        public Task<GetTourDTO?> GetTourDTOAsync(int id);
        
        /// <summary>
        /// Asynchronously retrieves an UpdateTourDTO by its ID.
        /// </summary>
        /// <param name="id">The ID of the tour to update.</param>
        /// <returns>A Task representing the asynchronous operation, with an UpdateTourDTO as the result.</returns>
        public Task<UpdateTourDTO> GetUpdateTourDTOAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a paginated list of tours and the total count of tours.
        /// </summary>
        /// <param name="pageNumber">The page number for pagination.</param>
        /// <param name="pageSize">The number of tours per page.</param>
        /// <param name="search">Optional search parameter.</param>
        /// <param name="startDate">Optional start date filter.</param>
        /// <param name="endDate">Optional end date filter.</param>
        /// <returns>A Task representing the asynchronous operation, with a GetAllToursDTO as the result.</returns>
        public Task<GetAllToursDTO> GetTourDTOsAndToursCountAsync(int pageNumber, int pageSize, string? search = null, string? startDate = null, string? endDate = null);
        
        /// <summary>
        /// Asynchronously updates a tour.
        /// </summary>
        /// <param name="tour">The UpdateTourDTO containing updated tour information.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateTourAsync(UpdateTourDTO tour);
    }
}
