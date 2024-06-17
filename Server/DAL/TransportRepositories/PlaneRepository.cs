using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TransportRepositories
{
    public class PlaneRepository : ITransportRepository<Plane>
    {
        private readonly MainDbContext _context;
        public PlaneRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddTransportAsync(Plane transport)
        {
            _context.Planes.Add(transport);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransportAsync(int id)
        {
            var transport = await GetTransportAsync(id);
            if (transport != null)
            {
                _context.Planes.Remove(transport);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Plane?> GetTransportAsync(int id)
        {
            return await _context.Planes.FindAsync(id);
        }

        public async Task<List<Plane>> GetTransportsAsync()
        {
            return await _context.Planes.ToListAsync();
        }

        public async Task UpdateTransportAsync(Plane transport)
        {
            _context.Planes.Update(transport);
            await _context.SaveChangesAsync();
        }
    }
}
