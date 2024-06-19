using MASProject.Server.DAL.Context;
using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.LodgingRepositories
{
    /// <summary>
    /// Repository class for lodging operations.
    /// </summary>
    public class LodgingRepository : ILodgingRepository
    {
        private readonly MainDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public LodgingRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<Lodging?> GetLodgingAsync(int id)
        {
            return await _context.Lodgings.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<List<Lodging>> GetLodgingsAsync()
        {
            return await _context.Lodgings.ToListAsync();
        }

        /// <inheritdoc />
        public async Task AddLodgingAsync(Lodging lodging)
        {
            _context.Lodgings.Add(lodging);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteLodgingAsync(int id)
        {
            var lodging = await GetLodgingAsync(id);
            if (lodging != null)
            {
                _context.Lodgings.Remove(lodging);
                await _context.SaveChangesAsync();
            }
        }

        /// <inheritdoc />
        public async Task UpdateLodgingAsync(Lodging lodging)
        {
            _context.Lodgings.Update(lodging);
            await _context.SaveChangesAsync();
        }
    }
}
