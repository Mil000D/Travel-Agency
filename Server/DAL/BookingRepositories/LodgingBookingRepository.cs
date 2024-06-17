using MASProject.Server.DAL.Context;
using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.BookingRepositories
{
    public class LodgingBookingRepository : IBookingRepository<LodgingBooking>
    {
        private readonly MainDbContext _context;
        public LodgingBookingRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddBookingAsync(LodgingBooking booking)
        {
            _context.LodgingBookings.Add(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingAsync(int id, int tourId)
        {
            var booking = await _context.LodgingBookings
                         .FirstOrDefaultAsync(b => b.LodgingId == id && b.TourId == tourId);
            if (booking != null)
            {
                _context.LodgingBookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<LodgingBooking?> GetBookingAsync(int id, int tourId)
        {
            return await _context.LodgingBookings
                .Include(b => b.Lodging)
                .Include(b => b.Tour)
                .FirstOrDefaultAsync(b => b.LodgingId == id && b.TourId == tourId);
        }

        public async Task<List<LodgingBooking>> GetBookingsAsync()
        {
            return await _context.LodgingBookings
                .Include(b => b.Lodging)
                .Include(b => b.Tour)
                .ToListAsync();
        }

        public async Task UpdateBookingAsync(LodgingBooking booking)
        {
            _context.LodgingBookings.Update(booking);
            await _context.SaveChangesAsync();
        }
    }
}
