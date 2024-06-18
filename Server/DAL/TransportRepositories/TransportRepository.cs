using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TransportRepositories
{
    public class TransportRepository<T> : ITransportRepository<T> where T : Transport
    {
        private readonly MainDbContext _context;
        protected readonly DbSet<T> _transportSet;
        public TransportRepository(MainDbContext context)
        {
            _context = context;
            _transportSet = _context.Set<T>();
        }
        public async Task AddTransportAsync(T transport)
        {
            _transportSet.Add(transport);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransportAsync(int id)
        {
            var transport = await GetTransportAsync(id);
            if (transport != null)
            {
                _transportSet.Remove(transport);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<T?> GetTransportAsync(int id)
        {
            return await _transportSet.FindAsync(id);
        }

        public async Task<List<T>> GetTransportsAsync()
        {
            return await _transportSet.ToListAsync();
        }

        public async Task UpdateTransportAsync(T transport)
        {
            _transportSet.Update(transport);
            await _context.SaveChangesAsync();
        }
    }
}
