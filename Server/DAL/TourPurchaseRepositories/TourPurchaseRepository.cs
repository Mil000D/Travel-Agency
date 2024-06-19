using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TourModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TourPurchaseRepositories
{
    /// <summary>
    /// Repository class for tour purchase operations.
    /// </summary>
    public class TourPurchaseRepository : ITourPurchaseRepository
    {
        private readonly MainDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="TourPurchaseRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public TourPurchaseRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task AddTourPurchaseAsync(TourPurchase tourPurchase)
        {
            _context.TourPurchases.Add(tourPurchase);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteTourPurchaseAsync(int id)
        {
            var tourPurchase = await GetTourPurchaseAsync(id);
            if (tourPurchase != null)
            {
                _context.TourPurchases.Remove(tourPurchase);
                await _context.SaveChangesAsync();
            }
        }

        /// <inheritdoc />
        public async Task<TourPurchase?> GetTourPurchaseAsync(int id)
        {
            return await _context.TourPurchases.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<List<TourPurchase>> GetTourPurchasesAsync()
        {
            return await _context.TourPurchases.ToListAsync();
        }

        /// <inheritdoc />
        public async Task UpdateTourPurchaseAsync(TourPurchase tourPurchase)
        {
            _context.TourPurchases.Update(tourPurchase);
            await _context.SaveChangesAsync();
        }
    }
}
