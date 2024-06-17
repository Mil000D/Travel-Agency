using MASProject.Server.DAL.Context;
using MASProject.Server.Enums;
using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.TourModels;
using MASProject.Server.DAL.BookingRepositories;
using MASProject.Server.DAL.LodgingRepositories;
using MASProject.Server.DAL.TourRepositories;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Tests
{
    public class LodgingBookingTests
    {
        [Theory]
        [InlineData(2024, 7, 30, 2024, 6, 30)]
        [InlineData(2024, 7, 30, 2024, 7, 30)]
        [InlineData(2024, 5, 30, 2024, 6, 13)]
        public async Task Lodging_ShouldThrowValidationException_WhenCheckInDateIsAfterCheckoutDate(int yearCheckIn, int monthCheckIn, int dayCheckIn, int yearCheckOut, int monthCheckOut, int dayCheckOut)
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "Lodging_ShouldThrowValidationException_WhenCheckInDateIsAfterCheckoutDate")
                .Options;

            using var context = new MainDbContext(options);
            var lodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "1232323",
                Email = "email@email.com",
                OfficialWebsiteURL = "OfficialWebsiteURL",
                Amenities = new List<string> { "Amenity" },
                LodgingType = LodgingType.Hotel,
            };
            var tour = new Tour
            {
                Title = "Title",
                Description = "Description",
                Popularity = 1,
                ImagesURL = new List<string> { "Image.jpg" },
            };
            var lodgingBooking = new LodgingBooking
            {
                LodgingId = 1,
                TourId = 1,
                RoomType = "Single",
                MaxCapacity = 1,
                CheckInDate = new DateOnly(yearCheckIn, monthCheckIn, dayCheckIn),
                CheckOutDate = new DateOnly(yearCheckOut, monthCheckOut, dayCheckOut)
            };
            var lodgingRepository = new LodgingRepository(context);
            var tourRepository = new TourRepository(context);
            var lodgingBookingRepository = new LodgingBookingRepository(context);

            await lodgingRepository.AddLodgingAsync(lodging);
            await tourRepository.AddTourAsync(tour);
            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await lodgingBookingRepository.AddBookingAsync(lodgingBooking);
            });
        }

        [Fact]
        public async Task AddLodgingBookingAsync_ShouldAddLodgingBooking_WhenTourAndLodgingAreAvailable()
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "AddLodgingBookingAsync_ShouldAddLodgingBooking")
                .Options;

            using var context = new MainDbContext(options);
            var lodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "1232323",
                Email = "email@email.com",
                OfficialWebsiteURL = "OfficialWebsiteURL",
                Amenities = new List<string> { "Amenity" },
                LodgingType = LodgingType.Hotel,
            };
            var tour = new Tour
            {
                Title = "Title",
                Description = "Description",
                Popularity = 1,
                ImagesURL = new List<string> { "Image.jpg" },
            };
            var lodgingBooking = new LodgingBooking
            {
                LodgingId = 1,
                TourId = 1,
                RoomType = "Single",
                MaxCapacity = 1,
                CheckInDate = new DateOnly(2025, 1, 1),
                CheckOutDate = new DateOnly(2025, 1, 2)
            };
            var lodgingRepository = new LodgingRepository(context);
            var tourRepository = new TourRepository(context);
            var lodgingBookingRepository = new LodgingBookingRepository(context);
            
            await lodgingRepository.AddLodgingAsync(lodging);
            await tourRepository.AddTourAsync(tour);
            await lodgingBookingRepository.AddBookingAsync(lodgingBooking);

            var result = await context.LodgingBookings.FirstOrDefaultAsync();
            Assert.Equal(lodgingBooking, result);
            var result2 = await context.Lodgings.FirstOrDefaultAsync();
            Assert.Equal(lodgingBooking, result2?.LodgingBookings?.FirstOrDefault());
            var result3 = await context.Tours.FirstOrDefaultAsync();
            Assert.Equal(lodgingBooking, result3?.LodgingBookings?.FirstOrDefault());
        }
    }
}
