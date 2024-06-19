using MASProject.Server.DAL.Context;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.BookingRepositories
{
    /// <summary>
    /// Repository class for transport booking operations.
    /// </summary>
    public class TransportBookingRepository : IBookingRepository<TransportBooking>
    {
        private readonly MainDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportBookingRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public TransportBookingRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task AddBookingAsync(TransportBooking booking)
        {
            _context.TransportBookings.Add(booking);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task<TransportBooking?> GetBookingAsync(int id, int tourId)
        {
            return await _context.TransportBookings
                .Include(b => b.Transport)
                .Include(b => b.Tour)
                .FirstOrDefaultAsync(b => b.TransportId == id && b.TourId == tourId);
        }

        /// <inheritdoc />
        public async Task<List<TransportBooking>> GetBookingsAsync()
        {
            return await _context.TransportBookings
                .Include(b => b.Transport)
                .Include(b => b.Tour)
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task UpdateBookingAsync(TransportBooking booking)
        {
            _context.TransportBookings.Update(booking);
            await _context.SaveChangesAsync();
        }
    }
}
