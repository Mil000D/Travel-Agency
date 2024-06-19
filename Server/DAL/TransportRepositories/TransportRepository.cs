using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TransportRepositories
{
    /// <summary>
    /// Generic repository class for transport operations.
    /// </summary>
    /// <typeparam name="T">Type of transport, must inherit from <see cref="Transport"/>.</typeparam>
    public class TransportRepository<T> : ITransportRepository<T> where T : Transport
    {
        private readonly MainDbContext _context;
        protected readonly DbSet<T> _transportSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportRepository{T}"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public TransportRepository(MainDbContext context)
        {
            _context = context;
            _transportSet = _context.Set<T>();
        }

        /// <inheritdoc/>
        public async Task AddTransportAsync(T transport)
        {
            _transportSet.Add(transport);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteTransportAsync(int id)
        {
            var transport = await GetTransportAsync(id);
            if (transport != null)
            {
                _transportSet.Remove(transport);
                await _context.SaveChangesAsync();
            }
        }

        /// <inheritdoc/>
        public async Task<T?> GetTransportAsync(int id)
        {
            return await _transportSet.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<List<T>> GetTransportsAsync()
        {
            return await _transportSet.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task UpdateTransportAsync(T transport)
        {
            _transportSet.Update(transport);
            await _context.SaveChangesAsync();
        }
    }
}
