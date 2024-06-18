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
            return await _context.Tours.Include(t => t.TransportBookings).ThenInclude(tb => tb.Transport)
                .Include(t => t.LodgingBookings).ThenInclude(lb => lb.Lodging)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<(List<Tour>, int)> GetToursAndToursCountAsync(int pageNumber, int pageSize, string? search = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = _context.Tours.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(t => t.Title.ToLower().Contains(search.ToLower()) || t.Description.ToLower().Contains(search.ToLower()));
            }

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(t => t.TransportBookings.Any(tb => tb.DepartureTime >= startDate && tb.ArrivalTime <= endDate));
            }
            var queryResult = await query
                    .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return (queryResult, await query.CountAsync());
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
