using MASProject.Server.Comparers;
using MASProject.Server.Converters;
using MASProject.Server.Enums;
using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    public class LodgingEntityTypeConfiguration : IEntityTypeConfiguration<Lodging>
    {
        public void Configure(EntityTypeBuilder<Lodging> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(l => l.Address)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(l => l.Description)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(l => l.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(l => l.Email)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(l => l.Owner)
                   .HasMaxLength(50);

            builder.Property(l => l.Stars)
                   .IsRequired(false);

            builder.Property(l => l.OfficialWebsiteURL)
                   .HasMaxLength(100);

            builder.Property(l => l.Amenities)
                   .IsRequired(false)
                   .HasConversion(new ListOfStringsConverterNullable("#"))
                   .Metadata.SetValueComparer(new ListOfStringsComparer());

            builder.Property(l => l.PetFriendly)
                   .IsRequired(false);

            builder.Property(l => l.BreakfastIncluded)
                   .IsRequired(false);

            builder.Property(l => l.LodgingType)
                   .IsRequired();

            builder.HasData(
                new Lodging
                {
                    Id = 1,
                    Name = "Lake Powell Hotel",
                    Address = "750 S Navajo Dr, Page, AZ 86040, USA",
                    Description = "Set 2 miles from Glen Canyon Dam Overlook at Lake Powell, this unfussy motel is 8 minutes' walk from the Powell Museum, and 5 miles from Lake Powell Navajo Tribal Park.",
                    Stars = 3,
                    OfficialWebsiteURL = "https://lakepowellmotel.net/",
                    Amenities = new List<string> { "Free Wi-Fi", "Free parking", "Air-conditioned", "Laundry service", "Kid-friendly", "Pet-friendly" },
                    PhoneNumber = "19286459362",
                    Email = "lakepowellhotel@gmail.com",
                    LodgingType = LodgingType.Hotel,
                },
                new Lodging
                {
                    Id = 2,
                    Name = "Niagara Falls Inn Near The Falls",
                    Address = "7280 Lundy's Ln, Niagara Falls, ON L2G 1W2, Canada",
                    Description = "Beatiful inn next to Niagra Falls",
                    Stars = 4,
                    PetFriendly = true,
                    BreakfastIncluded = true,
                    PhoneNumber = "19053583621",
                    Email = "niagarafalls@gmail.com",
                    LodgingType = LodgingType.Inn
                },
                new Lodging
                {
                    Id = 3,
                    Name = "The Grand Hotel at the Grand Canyon",
                    Address = "149 AZ-64, Grand Canyon Village, AZ 86023, United States",
                    Description = "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    OfficialWebsiteURL = "http://www.grandcanyongrandhotel.com/",
                    Amenities = new List<string> { "Free Wi-Fi", "Free parking", "Air-conditioned", "Laundry service", "Kid-friendly", "Pet-friendly" },
                    PhoneNumber = "14286383333",
                    Email = "grandcanyon@hotel.com",
                    LodgingType = LodgingType.Hotel
                },
                new Lodging
                {
                    Id = 4,
                    Name = "Lake Powell Canyon Inn",
                    Address = "150 N Lake Powell Blvd, Page, AZ 86040, United States",
                    Description = "Beatiful inn next to Horseshoe Bend",
                    PetFriendly = false,
                    BreakfastIncluded = false,
                    PhoneNumber = "18286452416",
                    Email = "innpowell@canyon.com",
                    LodgingType = LodgingType.Inn
                },
                new Lodging
                {
                    Id = 5,
                    Name = "Yellowstone Hotel",
                    Address = "1 Grand Loop Rd, Yellowstone National Park, WY 82190, United States",
                    Description = "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    OfficialWebsiteURL = "http://www.yellowstonehotel.com/",
                    Amenities = new List<string> { "Free Wi-Fi", "Free parking", "Air-conditioned", "Laundry service", "Kid-friendly", "Pet-friendly" },
                    PhoneNumber = "111213183333",
                    Email = "yellowstone@hotel.com",
                    LodgingType = LodgingType.Hotel
                },
                new Lodging
                {
                    Id = 6,
                    Name = "The Ahwahnee",
                    Address = "1 Ahwahnee Dr, Yosemite Valley, CA 95389, United States",
                    Description = "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    OfficialWebsiteURL = "http://www.ahwahnee.com/",
                    Amenities = new List<string> { "Free Wi-Fi", "Free parking", "Air-conditioned", "Laundry service", "Kid-friendly", "Pet-friendly" },
                    PhoneNumber = "1943434383333",
                    Email = "ahwahnee@gmail.com",
                    LodgingType = LodgingType.Hotel
                },
                new Lodging
                {
                    Id = 7,
                    Name = "Zion National Park Lodge",
                    Address = "1 Zion Park Blvd, Springdale, UT 84767, United States",
                    Description = "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    OfficialWebsiteURL = "http://www.zionlodge.com/",
                    Amenities = new List<string> { "Free Wi-Fi", "Free parking", "Air-conditioned", "Laundry service", "Kid-friendly", "Pet-friendly" },
                    PhoneNumber = "11322343333",
                    Email = "zion@gmail.com",
                    LodgingType = LodgingType.Hotel
                },
                new Lodging
                {
                    Id = 8,
                    Name = "Bryce Canyon Inn",
                    Address = "Highway 63, Bryce Canyon National Park, UT 84764, United States",
                    Description = "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    PetFriendly = true,
                    BreakfastIncluded = false,
                    PhoneNumber = "19281113333",
                    Email = "bryce@canyon.com",
                    LodgingType = LodgingType.Inn
                },
                new Lodging
                {
                    Id = 9,
                    Name = "Monument Valley Inn",
                    Address = "US-163, Oljato-Monument Valley, UT 84536, United States",
                    Description = "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    PetFriendly = true,
                    BreakfastIncluded = false,
                    PhoneNumber = "12323413333",
                    Email = "monument@valley.com",
                    LodgingType = LodgingType.Inn
                },
                new Lodging
                {
                    Id = 10,
                    Name = "Arches National Park Inn",
                    Address = "Moab, UT 84532, United States",
                    Description = "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    PetFriendly = true,
                    BreakfastIncluded = false,
                    PhoneNumber = "128888667633",
                    Email = "arches@gmail.com",
                    LodgingType = LodgingType.Inn
                },
                new Lodging
                {
                    Id = 11,
                    Name = "Canyonlands National Park Inn",
                    Address = "Moab, UT 84532, United States",
                    Description = "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.",
                    Stars = 4,
                    PetFriendly = true,
                    BreakfastIncluded = true,
                    PhoneNumber = "132328667633",
                    Email = "canyonlands@gmail.com",
                    LodgingType = LodgingType.Inn
                }
            );
        }
    }
}
