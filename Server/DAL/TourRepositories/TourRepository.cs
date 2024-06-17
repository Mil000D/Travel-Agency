using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TourModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.TourRepositories
{
    public class TourRepository : ITourRepository
    {
        private readonly MainDbContext _context;
        public TourRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task AddTourAsync(Tour tour)
        {
            _context.Tours.Add(tour);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTourAsync(int id)
        {
            var tour = await GetTourAsync(id);
            if (tour != null)
            {
                _context.Tours.Remove(tour);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Tour?> GetTourAsync(int id)
        {
            return await _context.Tours.FindAsync(id);
        }

        public async Task<List<Tour>> GetToursAsync(int pageNumber, int pageSize)
        {
            return await _context.Tours
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetToursCountAsync()
        {
            return await _context.Tours.CountAsync();
        }

        public async Task UpdateTourAsync(Tour tour)
        {
            _context.Tours.Update(tour);
            await _context.SaveChangesAsync();
        }
    }
}
