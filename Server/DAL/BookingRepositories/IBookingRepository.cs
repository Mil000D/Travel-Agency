using MASProject.Server.Models.SharedModels;

namespace MASProject.Server.DAL.BookingRepositories
{
    /// <summary>
    /// Generic interface for booking repository operations.
    /// </summary>
    /// <typeparam name="T">Type of booking, must inherit from <see cref="Booking"/>.</typeparam>
    public interface IBookingRepository<T> where T : Booking
    {
        /// <summary>
        /// Asynchronously retrieves a booking by ID and tour ID.
        /// </summary>
        /// <param name="id">The ID of the booking.</param>
        /// <param name="tourId">The ID of the tour.</param>
        /// <returns>A Task representing the asynchronous operation, with the booking as the result.</returns>
        public Task<T?> GetBookingAsync(int id, int tourId);

        /// <summary>
        /// Asynchronously retrieves all bookings.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation, with a list of bookings as the result.</returns>
        public Task<List<T>> GetBookingsAsync();

        /// <summary>
        /// Asynchronously adds a booking.
        /// </summary>
        /// <param name="booking">The booking to add.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task AddBookingAsync(T booking);

        /// <summary>
        /// Asynchronously updates a booking.
        /// </summary>
        /// <param name="booking">The booking to update.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateBookingAsync(T booking);

        /// <summary>
        /// Asynchronously deletes a booking by ID and tour ID.
        /// </summary>
        /// <param name="id">The ID of the booking.</param>
        /// <param name="tourId">The ID of the tour.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteBookingAsync(int id, int tourId);
    }
}
