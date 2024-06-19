using MASProject.Server.DAL.Context;
using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.BookingRepositories
{
    /// <summary>
    /// Repository class for lodging booking operations.
    /// </summary>
    public class LodgingBookingRepository : IBookingRepository<LodgingBooking>
    {
        private readonly MainDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingBookingRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public LodgingBookingRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task AddBookingAsync(LodgingBooking booking)
        {
            _context.LodgingBookings.Add(booking);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task<LodgingBooking?> GetBookingAsync(int id, int tourId)
        {
            return await _context.LodgingBookings
                .Include(b => b.Lodging)
                .Include(b => b.Tour)
                .FirstOrDefaultAsync(b => b.LodgingId == id && b.TourId == tourId);
        }

        /// <inheritdoc />
        public async Task<List<LodgingBooking>> GetBookingsAsync()
        {
            return await _context.LodgingBookings
                .Include(b => b.Lodging)
                .Include(b => b.Tour)
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task UpdateBookingAsync(LodgingBooking booking)
        {
            _context.LodgingBookings.Update(booking);
            await _context.SaveChangesAsync();
        }
    }
}
