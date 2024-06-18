using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    public class LodgingBookingEntityTypeConfiguration : IEntityTypeConfiguration<LodgingBooking>
    {
        public void Configure(EntityTypeBuilder<LodgingBooking> builder)
        {
            builder.HasKey(tb => new { tb.TourId, tb.LodgingId });
            builder.Property(lb => lb.RoomType)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(b => b.Price)
                .IsRequired();

            builder.Property(lb => lb.MaxCapacity)
                   .IsRequired();

            builder.Property(lb => lb.CheckInDate)
                   .IsRequired();

            builder.Property(lb => lb.CheckOutDate)
                   .IsRequired();

            builder.HasData(
                new LodgingBooking
                {
                    TourId = 1,
                    LodgingId = 1,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 1, 1),
                    CheckOutDate = new DateOnly(2025, 2, 2),
                    Price = 1000
                },
                new LodgingBooking
                {
                    TourId = 2,
                    LodgingId = 2,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 3, 1),
                    CheckOutDate = new DateOnly(2025, 4, 2),
                    Price = 1000
                },
                new LodgingBooking
                {
                    TourId = 3,
                    LodgingId = 3,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 4, 1),
                    CheckOutDate = new DateOnly(2025, 5, 2),
                    Price = 500
                },
                new LodgingBooking
                {
                    TourId = 4,
                    LodgingId = 4,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 5, 1),
                    CheckOutDate = new DateOnly(2025, 6, 2),
                    Price = 2000
                },
                new LodgingBooking
                {
                    TourId = 5,
                    LodgingId = 4,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 6, 1),
                    CheckOutDate = new DateOnly(2025, 7, 2),
                    Price = 1000
                },
                new LodgingBooking
                {
                    TourId = 6,
                    LodgingId = 5,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 7, 1),
                    CheckOutDate = new DateOnly(2025, 8, 2),
                    Price = 1000
                },
                new LodgingBooking
                {
                    TourId = 7,
                    LodgingId = 6,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 8, 1),
                    CheckOutDate = new DateOnly(2025, 9, 2),
                    Price = 500
                },
                new LodgingBooking
                {
                    TourId = 8,
                    LodgingId = 7,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 9, 1),
                    CheckOutDate = new DateOnly(2025, 10, 2),
                    Price = 2000
                },
                new LodgingBooking
                {
                    TourId = 9,
                    LodgingId = 8,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 10, 1),
                    CheckOutDate = new DateOnly(2025, 11, 2),
                    Price = 1000
                },
                new LodgingBooking
                {
                    TourId = 10,
                    LodgingId = 9,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 11, 1),
                    CheckOutDate = new DateOnly(2025, 12, 2),
                    Price = 1000
                },
                new LodgingBooking
                {
                    TourId = 11,
                    LodgingId = 10,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 12, 1),
                    CheckOutDate = new DateOnly(2026, 1, 2),
                    Price = 500
                },
                new LodgingBooking
                {
                    TourId = 12,
                    LodgingId = 11,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2026, 1, 1),
                    CheckOutDate = new DateOnly(2026, 2, 2),
                    Price = 2000
                }
            );
        }
    }
}
