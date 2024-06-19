using MASProject.Server.Models.LodgingModels;

namespace MASProject.Server.DAL.LodgingRepositories
{
    /// <summary>
    /// Interface for lodging repository operations.
    /// </summary>
    public interface ILodgingRepository
    {
        /// <summary>
        /// Asynchronously retrieves a lodging by ID.
        /// </summary>
        /// <param name="id">The ID of the lodging to retrieve.</param>
        /// <returns>A Task representing the asynchronous operation, with the lodging as the result.</returns>
        public Task<Lodging?> GetLodgingAsync(int id);

        /// <summary>
        /// Asynchronously retrieves all lodgings.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation, with a list of lodgings as the result.</returns>
        public Task<List<Lodging>> GetLodgingsAsync();

        /// <summary>
        /// Asynchronously adds a lodging.
        /// </summary>
        /// <param name="lodging">The lodging to add.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task AddLodgingAsync(Lodging lodging);

        /// <summary>
        /// Asynchronously updates a lodging.
        /// </summary>
        /// <param name="lodging">The lodging to update.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateLodgingAsync(Lodging lodging);

        /// <summary>
        /// Asynchronously deletes a lodging by ID.
        /// </summary>
        /// <param name="id">The ID of the lodging to delete.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteLodgingAsync(int id);
    }
}
