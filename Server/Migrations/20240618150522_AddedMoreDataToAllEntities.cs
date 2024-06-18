using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MASProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreDataToAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 1, 1 },
                column: "Price",
                value: 1000f);

            migrationBuilder.InsertData(
                table: "LodgingBookings",
                columns: new[] { "LodgingId", "TourId", "CheckInDate", "CheckOutDate", "MaxCapacity", "Price", "RoomType" },
                values: new object[,]
                {
                    { 2, 2, new DateOnly(2025, 3, 1), new DateOnly(2025, 4, 2), 2, 1000f, "Double" },
                    { 3, 3, new DateOnly(2025, 4, 1), new DateOnly(2025, 5, 2), 1, 500f, "Single" },
                    { 4, 4, new DateOnly(2025, 5, 1), new DateOnly(2025, 6, 2), 2, 2000f, "Double" },
                    { 4, 5, new DateOnly(2025, 6, 1), new DateOnly(2025, 7, 2), 1, 1000f, "Single" }
                });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Amenities", "Description", "Email", "Name", "OfficialWebsiteURL", "PhoneNumber", "Stars" },
                values: new object[] { "750 S Navajo Dr, Page, AZ 86040, USA", "Free Wi-Fi#Free parking#Air-conditioned#Laundry service#Kid-friendly#Pet-friendly", "Set 2 miles from Glen Canyon Dam Overlook at Lake Powell, this unfussy motel is 8 minutes' walk from the Powell Museum, and 5 miles from Lake Powell Navajo Tribal Park.", "lakepowellhotel@gmail.com", "Lake Powell Hotel", "https://lakepowellmotel.net/", "19286459362", 3 });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "BreakfastIncluded", "Description", "Email", "LodgingType", "Name", "PetFriendly", "PhoneNumber", "Stars" },
                values: new object[] { "7280 Lundy's Ln, Niagara Falls, ON L2G 1W2, Canada", true, "Beatiful inn next to Niagra Falls", "niagarafalls@gmail.com", 1, "Niagara Falls Inn Near The Falls", true, "19053583621", 4 });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Amenities", "Description", "Email", "Name", "OfficialWebsiteURL", "PhoneNumber", "Stars" },
                values: new object[] { "149 AZ-64, Grand Canyon Village, AZ 86023, United States", "Free Wi-Fi#Free parking#Air-conditioned#Laundry service#Kid-friendly#Pet-friendly", "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "grandcanyon@hotel.com", "The Grand Hotel at the Grand Canyon", "http://www.grandcanyongrandhotel.com/", "14286383333", 4 });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "BreakfastIncluded", "Description", "Email", "LodgingType", "Name", "PetFriendly", "PhoneNumber" },
                values: new object[] { "150 N Lake Powell Blvd, Page, AZ 86040, United States", false, "Beatiful inn next to Horseshoe Bend", "innpowell@canyon.com", 1, "Lake Powell Canyon Inn", false, "18286452416" });

            migrationBuilder.InsertData(
                table: "Lodgings",
                columns: new[] { "Id", "Address", "Amenities", "BreakfastIncluded", "Description", "Email", "LodgingType", "Name", "OfficialWebsiteURL", "Owner", "PetFriendly", "PhoneNumber", "Stars" },
                values: new object[,]
                {
                    { 5, "1 Grand Loop Rd, Yellowstone National Park, WY 82190, United States", "Free Wi-Fi#Free parking#Air-conditioned#Laundry service#Kid-friendly#Pet-friendly", null, "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "yellowstone@hotel.com", 0, "Yellowstone Hotel", "http://www.yellowstonehotel.com/", null, null, "111213183333", 4 },
                    { 6, "1 Ahwahnee Dr, Yosemite Valley, CA 95389, United States", "Free Wi-Fi#Free parking#Air-conditioned#Laundry service#Kid-friendly#Pet-friendly", null, "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "ahwahnee@gmail.com", 0, "The Ahwahnee", "http://www.ahwahnee.com/", null, null, "1943434383333", 4 },
                    { 7, "1 Zion Park Blvd, Springdale, UT 84767, United States", "Free Wi-Fi#Free parking#Air-conditioned#Laundry service#Kid-friendly#Pet-friendly", null, "This rustic lodge-style hotel is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "zion@gmail.com", 0, "Zion National Park Lodge", "http://www.zionlodge.com/", null, null, "11322343333", 4 },
                    { 8, "Highway 63, Bryce Canyon National Park, UT 84764, United States", null, false, "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "bryce@canyon.com", 1, "Bryce Canyon Inn", null, null, true, "19281113333", 4 },
                    { 9, "US-163, Oljato-Monument Valley, UT 84536, United States", null, false, "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "monument@valley.com", 1, "Monument Valley Inn", null, null, true, "12323413333", 4 },
                    { 10, "Moab, UT 84532, United States", null, false, "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "arches@gmail.com", 1, "Arches National Park Inn", null, null, true, "128888667633", 4 },
                    { 11, "Moab, UT 84532, United States", null, true, "This rustic lodge-style inn is 2 miles from Grand Canyon National Park and a 6-minute walk from the Grand Canyon Imax Theatre.", "canyonlands@gmail.com", 1, "Canyonlands National Park Inn", null, null, true, "132328667633", 4 }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagesURL",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/af/93/2e.jpg https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/af/93/36.jpg");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagesURL",
                value: "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/21/de/5b/97/caption.jpg https://dynamic-media-cdn.tripadvisor.com/media/photo-o/21/de/5b/c2/caption.jpg");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagesURL",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/07/79/64/21.jpg");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagesURL",
                value: "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/dc/dd/3d/mesa-arch-view.jpg");

            migrationBuilder.UpdateData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[] { new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Niagara Falls", "Toronto", 100f });

            migrationBuilder.InsertData(
                table: "TransportBookings",
                columns: new[] { "TourId", "TransportId", "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Grand Canyon", "Las Vegas", 200f },
                    { 4, 4, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Horseshoe Bend", "Las Vegas", 200f },
                    { 5, 5, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Lake Powell", "Las Vegas", 200f },
                    { 6, 6, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Yellowstone National Park", "Washington DC", 200f },
                    { 7, 7, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Yosemite Valley", "San Francisco", 200f }
                });

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Company",
                value: "Alaska Airlines");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Company",
                value: "American Airlines");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 3,
                column: "Company",
                value: "Allegiant Air");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 4,
                column: "Company",
                value: "American Airlines");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 5,
                column: "Company",
                value: "Frontier Airlines");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Company", "Description", "TrainNumber" },
                values: new object[] { "Amtrak", "The National Railroad Passenger Corporation, doing business as Amtrak (reporting marks AMTK, AMTZ), is the national passenger railroad company of the United States.", "Q621-5" });

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Company", "Description", "TrainNumber" },
                values: new object[] { 200, "BNSF Railway", "BNSF Railway (reporting mark BNSF) is the largest freight railroad in the United States. One of six North American Class I railroads, BNSF has 36,000 employees, 33,400 miles (53,800 km) of track in 28 states, and over 8,000 locomotives.", "S321-5" });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "AirConditioning", "Capacity", "CargoCapacity", "Classes", "Company", "Description", "Discriminator", "MaxSpeed", "TrainNumber", "TransportType" },
                values: new object[,]
                {
                    { 8, false, 300, null, 4, "Union Railroad", "The Union Pacific Railroad (reporting mark UP) is a Class I line haul freight railroad that operates 8,300 locomotives over 31,800 route-miles in 23 states west of Chicago and New Orleans.", "Train", null, "U321-5", 1 },
                    { 9, true, 100, null, 4, "Canadian Railway", "The Canadian National Railway Company (reporting mark CN) is a Canadian Class I freight railway headquartered in Montreal, Quebec, which serves Canada and the Midwestern and Southern United States.", "Train", null, "C321-5", 1 },
                    { 10, true, 100, null, 4, "Kansas Railway", "The Kansas City Southern Railway Company (reporting mark KCS) is an American Class I railroad that operates over 3,300 route miles (5,300 km) in 10 states in the central and southern United States.", "Train", null, "K321-5", 1 },
                    { 11, true, 100, null, 4, "Norfolk Railway", "The Norfolk Southern Railway (reporting mark NS) is a Class I freight railroad in the United States. With headquarters in Atlanta, Georgia, the company operates 19,420 route miles (31,250 km) in 22 eastern states, the District of Columbia, and has rights in Canada over the Albany to Montréal route of the Canadian Pacific Railway, and previously on CN from Buffalo to St. Thomas.", "Train", null, "N321-5", 1 },
                    { 12, true, 100, null, 4, "CSX", "The CSX Transportation (reporting mark CSXT) is a Class I freight railroad operating in the eastern United States and the Canadian provinces of Ontario and Quebec. The railroad operates approximately 21,000 route miles (34,000 km) of track.", "Train", null, "C321-5", 1 }
                });

            migrationBuilder.InsertData(
                table: "LodgingBookings",
                columns: new[] { "LodgingId", "TourId", "CheckInDate", "CheckOutDate", "MaxCapacity", "Price", "RoomType" },
                values: new object[,]
                {
                    { 5, 6, new DateOnly(2025, 7, 1), new DateOnly(2025, 8, 2), 2, 1000f, "Double" },
                    { 6, 7, new DateOnly(2025, 8, 1), new DateOnly(2025, 9, 2), 1, 500f, "Single" },
                    { 7, 8, new DateOnly(2025, 9, 1), new DateOnly(2025, 10, 2), 2, 2000f, "Double" },
                    { 8, 9, new DateOnly(2025, 10, 1), new DateOnly(2025, 11, 2), 1, 1000f, "Single" },
                    { 9, 10, new DateOnly(2025, 11, 1), new DateOnly(2025, 12, 2), 2, 1000f, "Double" },
                    { 10, 11, new DateOnly(2025, 12, 1), new DateOnly(2026, 1, 2), 1, 500f, "Single" },
                    { 11, 12, new DateOnly(2026, 1, 1), new DateOnly(2026, 2, 2), 2, 2000f, "Double" }
                });

            migrationBuilder.InsertData(
                table: "TransportBookings",
                columns: new[] { "TourId", "TransportId", "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[,]
                {
                    { 8, 8, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "The Narrows", "New York", 200f },
                    { 9, 9, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Bryce Canyon National Park", "Las Vegas", 200f },
                    { 10, 10, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Monument Valley", "California", 200f },
                    { 11, 11, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Arches National Park", "Las Vegas", 200f },
                    { 12, 12, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Canyonlands National Park", "Washington DC", 200f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "LodgingBookings",
                keyColumns: new[] { "LodgingId", "TourId" },
                keyValues: new object[] { 1, 1 },
                column: "Price",
                value: 100f);

            migrationBuilder.InsertData(
                table: "LodgingBookings",
                columns: new[] { "LodgingId", "TourId", "CheckInDate", "CheckOutDate", "MaxCapacity", "Price", "RoomType" },
                values: new object[,]
                {
                    { 2, 1, new DateOnly(2025, 3, 1), new DateOnly(2025, 4, 2), 2, 200f, "Double" },
                    { 3, 2, new DateOnly(2025, 4, 1), new DateOnly(2025, 5, 2), 1, 100f, "Single" },
                    { 4, 2, new DateOnly(2025, 5, 1), new DateOnly(2025, 6, 2), 2, 200f, "Double" }
                });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Amenities", "Description", "Email", "Name", "OfficialWebsiteURL", "PhoneNumber", "Stars" },
                values: new object[] { "Address 1", null, "Description 1", "hotel@example.com", "Hotel 1", null, "2321231123", null });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "BreakfastIncluded", "Description", "Email", "LodgingType", "Name", "PetFriendly", "PhoneNumber", "Stars" },
                values: new object[] { "Address 2", null, "Description 2", "hotelnew@example.com", 0, "Hotel 2", null, "3232323222", null });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Amenities", "Description", "Email", "Name", "OfficialWebsiteURL", "PhoneNumber", "Stars" },
                values: new object[] { "Address 3", null, "Description 3", "inn@example.com", "Inn 1", null, "098776512", null });

            migrationBuilder.UpdateData(
                table: "Lodgings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "BreakfastIncluded", "Description", "Email", "LodgingType", "Name", "PetFriendly", "PhoneNumber" },
                values: new object[] { "Address 4", null, "Description 4", "innnew@example.com", 0, "Inn 2", null, "3232323232" });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagesURL",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagesURL",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagesURL",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagesURL",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg");

            migrationBuilder.UpdateData(
                table: "TransportBookings",
                keyColumns: new[] { "TourId", "TransportId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[] { new DateTime(2024, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "Abuja", "Lagos", 5000f });

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Company",
                value: "Boeing");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Company",
                value: "Airbus");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 3,
                column: "Company",
                value: "Boeing");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 4,
                column: "Company",
                value: "Airbus");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 5,
                column: "Company",
                value: "Boeing");

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Company", "Description", "TrainNumber" },
                values: new object[] { "Train Company", "This is a train", "123" });

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Company", "Description", "TrainNumber" },
                values: new object[] { 100, "Train Company 2", "This is a train 2", "456" });
        }
    }
}
