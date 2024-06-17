using MASProject.Server.DAL.Context;
using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.LodgingRepositories
{
    public class LodgingRepository : ILodgingRepository
    {
        private readonly MainDbContext _context;
        public LodgingRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task<Lodging?> GetLodgingAsync(int id)
        {
            return await _context.Lodgings.FindAsync(id);
        }
        public async Task<List<Lodging>> GetLodgingsAsync()
        {
            return await _context.Lodgings.ToListAsync();
        }
        public async Task AddLodgingAsync(Lodging lodging)
        {
            _context.Lodgings.Add(lodging);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteLodgingAsync(int id)
        {
            var lodging = await GetLodgingAsync(id);
            if (lodging != null)
            {
                _context.Lodgings.Remove(lodging);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateLodgingAsync(Lodging lodging)
        {
            _context.Lodgings.Update(lodging);
            await _context.SaveChangesAsync();
        }
    }
}
