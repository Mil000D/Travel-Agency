using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TourModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TourPurchaseRepositories
{
    public class TourPurchaseRepository : ITourPurchaseRepository
    {
        private readonly MainDbContext _context;
        public TourPurchaseRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddTourPurchaseAsync(TourPurchase tourPurchase)
        {
            _context.TourPurchases.Add(tourPurchase);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTourPurchaseAsync(int id)
        {
            var tourPurchase = await GetTourPurchaseAsync(id);
            if (tourPurchase != null)
            {
                _context.TourPurchases.Remove(tourPurchase);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TourPurchase?> GetTourPurchaseAsync(int id)
        {
            return await _context.TourPurchases.FindAsync(id);
        }

        public async Task<List<TourPurchase>> GetTourPurchasesAsync()
        {
            return await _context.TourPurchases.ToListAsync();
        }

        public async Task UpdateTourPurchaseAsync(TourPurchase tourPurchase)
        {
            _context.TourPurchases.Update(tourPurchase);
            await _context.SaveChangesAsync();
        }
    }
}
