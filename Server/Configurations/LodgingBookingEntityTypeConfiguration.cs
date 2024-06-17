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
                .HasPrecision(2);

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
                    Price = 100
                },
                new LodgingBooking
                {
                    TourId = 1,
                    LodgingId = 2,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 3, 1),
                    CheckOutDate = new DateOnly(2025, 4, 2),
                    Price = 200
                },
                new LodgingBooking
                {
                    TourId = 2,
                    LodgingId = 3,
                    RoomType = "Single",
                    MaxCapacity = 1,
                    CheckInDate = new DateOnly(2025, 4, 1),
                    CheckOutDate = new DateOnly(2025, 5, 2),
                    Price = 100
                },
                new LodgingBooking
                {
                    TourId = 2,
                    LodgingId = 4,
                    RoomType = "Double",
                    MaxCapacity = 2,
                    CheckInDate = new DateOnly(2025, 5, 1),
                    CheckOutDate = new DateOnly(2025, 6, 2),
                    Price = 200
                }
            );
        }
    }
}
