using MASProject.Server.Models.SharedModels;

namespace MASProject.Server.DAL.BookingRepositories
{
    public interface IBookingRepository<T> where T : Booking
    {
        public Task<T?> GetBookingAsync(int id, int tourId);
        public Task<List<T>> GetBookingsAsync();
        public Task AddBookingAsync(T booking);
        public Task UpdateBookingAsync(T booking);
        public Task DeleteBookingAsync(int id, int tourId);
    }
}
