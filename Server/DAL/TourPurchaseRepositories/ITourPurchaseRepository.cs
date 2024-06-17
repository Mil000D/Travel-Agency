using MASProject.Server.Models.TourModels;

namespace MASProject.Server.DAL.TourPurchaseRepositories
{
    public interface ITourPurchaseRepository
    {
        public Task AddTourPurchaseAsync(TourPurchase tourPurchase);
        public Task DeleteTourPurchaseAsync(int id);
        public Task<TourPurchase?> GetTourPurchaseAsync(int id);
        public Task<List<TourPurchase>> GetTourPurchasesAsync();
        public Task UpdateTourPurchaseAsync(TourPurchase tourPurchase);
    }
}
