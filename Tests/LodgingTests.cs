using MASProject.Server.DAL.Context;
using MASProject.Server.Enums;
using MASProject.Server.Models.LodgingModels;
using MASProject.Server.DAL.LodgingRepositories;
using System.ComponentModel.DataAnnotations;

namespace Tests
{
    public class LodgingTests
    {
        [Theory]
        [InlineData("Name", null, null, null, null, LodgingType.Hotel)]
        [InlineData(null, "Address", null, null, null, LodgingType.Hotel)]
        [InlineData(null, null, "Description", null, null, LodgingType.Hotel)]
        [InlineData(null, null, null, "Phone", null, LodgingType.Hotel)]
        [InlineData(null, null, null, null, "Email", LodgingType.Hotel)]
        [InlineData("Name", "Address", "Description", "Phone", "Email", LodgingType.Hotel)]
        public async Task Lodging_ShouldThrowValidationException_WhenRequiredPropertiesAreNotSet(string name, string address, string description, string phone, string email, LodgingType lodgingType)
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);

            var invalidLodging = new Lodging
            {
                Name = name,
                Address = address,
                Description = description,
                PhoneNumber = phone,
                Email = email,
                LodgingType = lodgingType
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }
        [Theory]
        [InlineData("OfficialWebsiteUrl", null)]
        [InlineData(null, new string[] { "Amenity" })]
        [InlineData(null, null)]
        public async Task Lodging_ShouldThrowValidationException_WhenLodgingIsHotelAndNeededDataWasNotProvided(string officialWebsiteURL, string[] amenities)
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);
            var invalidLodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "Phone",
                Email = "Email",
                OfficialWebsiteURL = officialWebsiteURL,
                Amenities = amenities is null ? null : amenities.ToList(),
                LodgingType = LodgingType.Hotel
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }
        [Theory]
        [InlineData(true, null)]
        [InlineData(null, false)]
        [InlineData(null, null)]
        public async Task Lodging_ShouldThrowValidationException_WhenLodgingIsInnAndNeededDataWasNotProvided(bool? petFriendly, bool? breakfastIncluded)
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);
            var invalidLodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "Phone",
                Email = "Email",
                PetFriendly = petFriendly,
                BreakfastIncluded = breakfastIncluded,
                LodgingType = LodgingType.Inn
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }

        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public async Task Lodging_ShouldThrowValidationException_WhenLodgingIsHotelAndDataNeededForInnIsSpecified(bool? petFriendly, bool? breakfastIncluded)
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);
            var invalidLodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "Phone",
                Email = "Email",
                OfficialWebsiteURL = "OfficialWebsiteURL",
                Amenities = new List<string>() { "Amenity" },
                PetFriendly = petFriendly,
                BreakfastIncluded = breakfastIncluded,
                LodgingType = LodgingType.Hotel
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }

        [Fact]
        public async Task Lodging_ShouldThrowValidationException_WhenStarsAreOutOfRange()
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);
            var invalidLodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "Phone",
                Email = "Email",
                Owner = "Owner",
                Stars = 6,
                OfficialWebsiteURL = "OfficialWebsiteURL",
                Amenities = new List<string>() { "Amenity" },
                LodgingType = LodgingType.Hotel
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }

        [Fact]
        public async Task Lodging_ShouldThrowValidationException_WhenLodgingTypeWasNotSpecified()
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);
            var invalidLodging = new Lodging
            {
                Name = "Name",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "Phone",
                Email = "Email",
            };

            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }

        [Fact]
        public async Task Lodging_ShouldThrowValidationException_WhenNameIsInvalid()
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new MainDbContext(options);

            var repository = new LodgingRepository(context);
            var invalidLodging = new Lodging
            {
                Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eu nibh vel mauris gravida aliquam nec at sapien. Proin eu neque viverra lectus auctor varius sed sed diam. Integer condimentum tempor rhoncus. Vestibulum id tortor urna. Etiam cursus, arcu nec lacinia ornare, eros tellus scelerisque nisl, id luctus ligula dui a lectus. Vestibulum non sapien a mi porta malesuada. Quisque nec felis nisi. Fusce et pellentesque ipsum.\r\n\r\nNunc id placerat purus. Phasellus in dui bibendum, congue dolor in, dignissim odio. Etiam pretium lorem et erat efficitur convallis. Nullam sollicitudin tempor est gravida molestie. Nulla facilisi. Sed pellentesque vel justo ac vulputate. Suspendisse potenti. Mauris dolor lectus, facilisis eget ullamcorper at, tempus at nisi. Quisque vitae orci in arcu tempor tincidunt. Donec sed sollicitudin nisi. In quis erat a purus gravida varius.",
                Address = "Address",
                Description = "Description",
                PhoneNumber = "Phone",
                Email = "Email",
                Owner = "Owner",
                Stars = 5,
                OfficialWebsiteURL = "OfficialWebsiteURL",
                Amenities = new List<string>() { "Amenity" },
                LodgingType = LodgingType.Hotel
            };
            await Assert.ThrowsAsync<ValidationException>(async () =>
            {
                await repository.AddLodgingAsync(invalidLodging);
            });
        }
    }
}
