using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MASProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataToAdminAndTourPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TourPurchases",
                columns: new[] { "CustomerId", "TourId", "PaymentDate", "PaymentMethod", "TourStatus" },
                values: new object[,]
                {
                    { 4, 4, new DateOnly(2024, 7, 4), 2, 1 },
                    { 4, 5, new DateOnly(2024, 8, 5), 1, 1 },
                    { 3, 6, new DateOnly(2024, 9, 6), 0, 1 },
                    { 2, 7, new DateOnly(2024, 10, 7), 2, 1 },
                    { 1, 8, new DateOnly(2024, 11, 8), 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Popularity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Popularity",
                value: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Discriminator", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 5, new DateOnly(1, 1, 1), "Admin", "Ryan", "password", "Doe", "adminryan" },
                    { 6, new DateOnly(1, 1, 1), "Admin", "Jack", "password", "Doe", "admindoe" },
                    { 7, new DateOnly(1, 1, 1), "Admin", "Alice", "password", "Doe", "adminalice" },
                    { 8, new DateOnly(1, 1, 1), "Admin", "Ethan", "password", "Smith", "adminethan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TourPurchases",
                keyColumns: new[] { "CustomerId", "TourId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TourPurchases",
                keyColumns: new[] { "CustomerId", "TourId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "TourPurchases",
                keyColumns: new[] { "CustomerId", "TourId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "TourPurchases",
                keyColumns: new[] { "CustomerId", "TourId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "TourPurchases",
                keyColumns: new[] { "CustomerId", "TourId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Popularity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Popularity",
                value: 0);
        }
    }
}
