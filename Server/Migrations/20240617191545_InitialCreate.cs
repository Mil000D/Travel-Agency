using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MASProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lodgings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Owner = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Stars = table.Column<int>(type: "INTEGER", nullable: true),
                    OfficialWebsiteURL = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Amenities = table.Column<string>(type: "TEXT", nullable: true),
                    PetFriendly = table.Column<bool>(type: "INTEGER", nullable: true),
                    BreakfastIncluded = table.Column<bool>(type: "INTEGER", nullable: true),
                    LodgingType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lodgings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Popularity = table.Column<int>(type: "INTEGER", nullable: true, defaultValue: 0),
                    ImagesURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Company = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    AirConditioning = table.Column<bool>(type: "INTEGER", nullable: true),
                    MaxSpeed = table.Column<int>(type: "INTEGER", nullable: true),
                    CargoCapacity = table.Column<int>(type: "INTEGER", nullable: true),
                    TransportType = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Amenities = table.Column<string>(type: "TEXT", nullable: true),
                    TrainNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Classes = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LodgingBookings",
                columns: table => new
                {
                    LodgingId = table.Column<int>(type: "INTEGER", nullable: false),
                    TourId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MaxCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckInDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    CheckOutDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<float>(type: "REAL", precision: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LodgingBookings", x => new { x.TourId, x.LodgingId });
                    table.ForeignKey(
                        name: "FK_LodgingBookings_Lodgings_LodgingId",
                        column: x => x.LodgingId,
                        principalTable: "Lodgings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LodgingBookings_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportBookings",
                columns: table => new
                {
                    TransportId = table.Column<int>(type: "INTEGER", nullable: false),
                    TourId = table.Column<int>(type: "INTEGER", nullable: false),
                    Origin = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Destination = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Price = table.Column<float>(type: "REAL", precision: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportBookings", x => new { x.TourId, x.TransportId });
                    table.ForeignKey(
                        name: "FK_TransportBookings_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportBookings_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourPurchases",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentMethod = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    TourStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourPurchases", x => new { x.TourId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_TourPurchases_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourPurchases_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lodgings",
                columns: new[] { "Id", "Address", "Amenities", "BreakfastIncluded", "Description", "Email", "LodgingType", "Name", "OfficialWebsiteURL", "Owner", "PetFriendly", "PhoneNumber", "Stars" },
                values: new object[,]
                {
                    { 1, "Address 1", null, null, "Description 1", "hotel@example.com", 0, "Hotel 1", null, null, null, "2321231123", null },
                    { 2, "Address 2", null, null, "Description 2", "hotelnew@example.com", 0, "Hotel 2", null, null, null, "3232323222", null },
                    { 3, "Address 3", null, null, "Description 3", "inn@example.com", 0, "Inn 1", null, null, null, "098776512", null },
                    { 4, "Address 4", null, null, "Description 4", "innnew@example.com", 0, "Inn 2", null, null, null, "3232323232", null }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Description", "ImagesURL", "Title" },
                values: new object[,]
                {
                    { 1, "Discover the lesser-traveled depths of Antelope Canyon on a walking tour through the lower portions of this colorful sandstone slot canyon.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/07/7f/67/da.jpg https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/90/31/4c/caption.jpg https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/8f/68/c5/caption.jpg https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/8f/68/ca/caption.jpg", "Lower Antelope Canyon" },
                    { 2, "Discover the highlights of several cities in the Northeast on this 4-day sightseeing tour by bus or minivan from Boston.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0d/46/b6/9c/20161010-133807-largejpg.jpg https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0c/7d/1f/18/photo3jpg.jpg https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/d4/be/31/view-from-one-of-the_rotated_90.jpg", "Niagara Falls" },
                    { 3, "Ideal for travelers short on time, this tour covers the Grand Canyon’s South Rim in one day of sightseeing from Las Vegas.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/3e.jpg", "Grand Canyon" },
                    { 4, "Journey to Horseshoe Bend on a guided tour that includes all your entrance fees, round-trip transport from Flagstaff, and a picnic lunch.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/17/56/c1/06/horseshoe-bend-az.jpg", "Horseshoe Bend" },
                    { 5, "This man-made reservoir, located in northern Arizona and southern Utah, is a great spot for travelers seeking nature and outdoor adventure.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/91/5b/02/morning-at-the-lake-powell.jpg", "Lake Powell" },
                    { 6, "Avoid crowds and maximize your wildlife-viewing experience on this private Yellowstone tour led by a naturalist guide.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/10/8e/af/dd.jpg", "Yellowstone Tour" },
                    { 7, "Immerse yourself in the majestic beauty of Yosemite National Park on this 2-day overnight adventure from San Francisco. Great way to spend holidays.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0b/2b/8a/7e.jpg", "Yosemite Valley" },
                    { 8, "Explore the Incredible Narrows portion of Zion National Park without the risk of getting lost on this private full-day tour. A fun day out for travelers.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0f/2c/ff/9e.jpg", "The Narrows" },
                    { 9, "Discover the stunning landscape of Bryce Canyon National Park on a full-day tour from Las Vegas that features a scenic round-trip journey by air.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg", "Bryce Canyon" },
                    { 10, "Explore Monument Valley Navajo Tribal Park on a full-day tour that features a visit to the Navajo Nation’s largest trading post.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg", "Monument Valley" },
                    { 11, "Discover the natural beauty of Arches National Park on this tour from Moab. A great way to spend a day out.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg", "Arches National Park" },
                    { 12, "Discover the natural beauty of Canyonlands National Park on this tour from Moab. A great way to spend a day out.", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg", "Canyonlands National Park" }
                });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "AirConditioning", "Amenities", "Capacity", "CargoCapacity", "Company", "Description", "Discriminator", "MaxSpeed", "Model", "TransportType" },
                values: new object[,]
                {
                    { 1, null, "Wi-Fi#In-flight entertainment#Power outlets", 660, 875, "Boeing", "The Boeing 747 is a large, long–range wide-body airliner designed and manufactured by Boeing Commercial Airplanes in the United States. It is among the world's most recognizable aircraft and was the first wide-body produced. Manufactured from 1968 to 2021, the 747 held the passenger capacity record for 37 years.", "Plane", 614, "Boeing 747", 0 },
                    { 2, null, "Wi-Fi#In-flight entertainment#Power outlets", 853, 1500, "Airbus", "The Airbus A380 is a wide-body aircraft manufactured by Airbus. It is the world's largest passenger airliner. Airbus studies started in 1988 and the project was announced in 1990 to challenge the dominance of the Boeing 747 in the long haul market.", "Plane", 587, "Airbus A380", 0 },
                    { 3, null, "Wi-Fi#In-flight entertainment#Power outlets", 550, 1000, "Boeing", "The Boeing 777 is a wide-body airliner developed and manufactured by Boeing Commercial Airplanes. It is the world's largest twinjet. The 777 was designed to bridge the gap between Boeing's other wide-body airliners and the 747.", "Plane", 590, "Boeing 777", 0 },
                    { 4, null, "Wi-Fi#In-flight entertainment#Power outlets", 440, 1000, "Airbus", "The Airbus A350 is a long-range, wide-body jet airliner developed by Airbus. The A350 is the first Airbus aircraft with both fuselage and wing structures made primarily of carbon-fibre-reinforced polymer. Its variants seat 280 to 366 passengers in typical three-class seating layouts.", "Plane", 567, "Airbus A350", 0 },
                    { 5, null, "Wi-Fi#In-flight entertainment#Power outlets", 330, 1000, "Boeing", "The Boeing 787 Dreamliner is an American wide-body jet airliner manufactured by Boeing Commercial Airplanes. Launched in April 2004, the 787 was designed to be more fuel-efficient than the Boeing 767, which it was intended to replace. The 787 Dreamliner's distinguishing features include mostly electrical flight systems, raked wingtips, and noise-reducing chevrons on its engine nacelles.", "Plane", 593, "Boeing 787", 0 }
                });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "AirConditioning", "Capacity", "CargoCapacity", "Classes", "Company", "Description", "Discriminator", "MaxSpeed", "TrainNumber", "TransportType" },
                values: new object[,]
                {
                    { 6, true, 100, null, 3, "Train Company", "This is a train", "Train", null, "123", 1 },
                    { 7, true, 100, null, 4, "Train Company 2", "This is a train 2", "Train", null, "456", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Discriminator", "Email", "Name", "Password", "PhoneNumber", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "Customer", "john@doe.com", "John", "password", "123456789", "Doe", "johndoe" },
                    { 2, new DateOnly(1, 1, 1), "Customer", "jane@doe.com", "Jane", "password", "987654321", "Doe", "janedoe" },
                    { 3, new DateOnly(1, 1, 1), "Customer", "alice@smith.com", "Alice", "password", "123123123", "Smith", "alicesmith" },
                    { 4, new DateOnly(1, 1, 1), "Customer", "bob@smith.com", "Bob", "password", "456456456", "Smith", "bobsmith" }
                });

            migrationBuilder.InsertData(
                table: "LodgingBookings",
                columns: new[] { "LodgingId", "TourId", "CheckInDate", "CheckOutDate", "MaxCapacity", "Price", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2025, 1, 1), new DateOnly(2025, 2, 2), 1, 100f, "Single" },
                    { 2, 1, new DateOnly(2025, 3, 1), new DateOnly(2025, 4, 2), 2, 200f, "Double" },
                    { 3, 2, new DateOnly(2025, 4, 1), new DateOnly(2025, 5, 2), 1, 100f, "Single" },
                    { 4, 2, new DateOnly(2025, 5, 1), new DateOnly(2025, 6, 2), 2, 200f, "Double" }
                });

            migrationBuilder.InsertData(
                table: "TourPurchases",
                columns: new[] { "CustomerId", "TourId", "PaymentDate", "PaymentMethod", "TourStatus" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2024, 10, 1), 2, 1 },
                    { 2, 2, new DateOnly(2024, 9, 2), 1, 1 },
                    { 3, 3, new DateOnly(2024, 8, 3), 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "TransportBookings",
                columns: new[] { "TourId", "TransportId", "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Lagos", "Abuja", 5000f },
                    { 2, 2, new DateTime(2024, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "Abuja", "Lagos", 5000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LodgingBookings_LodgingId",
                table: "LodgingBookings",
                column: "LodgingId");

            migrationBuilder.CreateIndex(
                name: "IX_TourPurchases_CustomerId",
                table: "TourPurchases",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportBookings_TransportId",
                table: "TransportBookings",
                column: "TransportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LodgingBookings");

            migrationBuilder.DropTable(
                name: "TourPurchases");

            migrationBuilder.DropTable(
                name: "TransportBookings");

            migrationBuilder.DropTable(
                name: "Lodgings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Transports");
        }
    }
}
