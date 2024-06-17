using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TransportRepositories
{
    public class TrainRepository : ITransportRepository<Train>
    {
        private readonly MainDbContext _context;
        public TrainRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddTransportAsync(Train transport)
        {
            _context.Trains.Add(transport);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransportAsync(int id)
        {
            var transport = await GetTransportAsync(id);
            if (transport != null)
            {
                _context.Trains.Remove(transport);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Train?> GetTransportAsync(int id)
        {
            return await _context.Trains.FindAsync(id);
        }

        public async Task<List<Train>> GetTransportsAsync()
        {
            return await _context.Trains.ToListAsync();
        }

        public async Task UpdateTransportAsync(Train transport)
        {
            _context.Trains.Update(transport);
            await _context.SaveChangesAsync();
        }
    }
}
