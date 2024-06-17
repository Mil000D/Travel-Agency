using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.BookingRepositories
{
    public class TransportBookingRepository : IBookingRepository<TransportBooking>
    {
        private readonly MainDbContext _context;

        public TransportBookingRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task AddBookingAsync(TransportBooking booking)
        {
            _context.TransportBookings.Add(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingAsync(int id, int tourId)
        {
            var booking = await _context.TransportBookings
                .FirstOrDefaultAsync(b => b.TransportId == id && b.TourId == tourId);
            if (booking != null)
            {
                _context.TransportBookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TransportBooking?> GetBookingAsync(int id, int tourId)
        {
            return await _context.TransportBookings
                .Include(b => b.Transport)
                .Include(b => b.Tour)
                .FirstOrDefaultAsync(b => b.TransportId == id && b.TourId == tourId);
        }

        public async Task<List<TransportBooking>> GetBookingsAsync()
        {
            return await _context.TransportBookings
                .Include(b => b.Transport)
                .Include(b => b.Tour)
                .ToListAsync();
        }

        public async Task UpdateBookingAsync(TransportBooking booking)
        {
            _context.TransportBookings.Update(booking);
            await _context.SaveChangesAsync();
        }
    }
}
