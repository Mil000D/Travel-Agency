using MASProject.Server.Models.TourModels;

namespace MASProject.Server.DAL.TourPurchaseRepositories
{
    /// <summary>
    /// Interface for tour purchase repository operations.
    /// </summary>
    public interface ITourPurchaseRepository
    {
        /// <summary>
        /// Asynchronously adds a tour purchase.
        /// </summary>
        /// <param name="tourPurchase">The tour purchase to add.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task AddTourPurchaseAsync(TourPurchase tourPurchase);

        /// <summary>
        /// Asynchronously deletes a tour purchase by ID.
        /// </summary>
        /// <param name="id">The ID of the tour purchase to delete.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteTourPurchaseAsync(int id);
       
        /// <summary>
        /// Asynchronously retrieves a tour purchase by ID.
        /// </summary>
        /// <param name="id">The ID of the tour purchase to retrieve.</param>
        /// <returns>A Task representing the asynchronous operation, with the tour purchase as the result.</returns>
        public Task<TourPurchase?> GetTourPurchaseAsync(int id);
        
        /// <summary>
        /// Asynchronously retrieves all tour purchases.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation, with a list of tour purchases as the result.</returns>
        public Task<List<TourPurchase>> GetTourPurchasesAsync();
        
        /// <summary>
        /// Asynchronously updates a tour purchase.
        /// </summary>
        /// <param name="tourPurchase">The tour purchase to update.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateTourPurchaseAsync(TourPurchase tourPurchase);
    }
}
