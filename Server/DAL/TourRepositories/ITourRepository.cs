using MASProject.Server.Models.TourModels;

namespace MASProject.Server.DAL.TourRepositories
{
    /// <summary>
    /// Interface for tour repository operations.
    /// </summary>
    public interface ITourRepository
    {
        /// <summary>
        /// Asynchronously adds a tour.
        /// </summary>
        /// <param name="tour">The tour to add.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task AddTourAsync(Tour tour);

        /// <summary>
        /// Asynchronously deletes a tour by ID.
        /// </summary>
        /// <param name="id">The ID of the tour to delete.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteTourAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a tour by ID.
        /// </summary>
        /// <param name="id">The ID of the tour to retrieve.</param>
        /// <returns>A Task representing the asynchronous operation, with the tour as the result.</returns>
        public Task<Tour?> GetTourAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a paginated list of tours and the total count of tours.
        /// </summary>
        /// <param name="pageNumber">The page number for pagination.</param>
        /// <param name="pageSize">The number of tours per page.</param>
        /// <param name="search">Optional search parameter.</param>
        /// <param name="startDate">Optional start date filter.</param>
        /// <param name="endDate">Optional end date filter.</param>
        /// <returns>A Task representing the asynchronous operation, with a tuple containing a list of tours and the total count of tours as the result.</returns>
        public Task<(List<Tour>, int)> GetToursAndToursCountAsync(int pageNumber, int pageSize, string? search = null, DateTime? startDate = null, DateTime? endDate = null);
        
        /// <summary>
        /// Asynchronously updates a tour.
        /// </summary>
        /// <param name="tour">The tour to update.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateTourAsync(Tour tour);
    }
}
