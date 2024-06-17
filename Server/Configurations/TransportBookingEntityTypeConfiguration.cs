using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    public class TransportBookingEntityTypeConfiguration : IEntityTypeConfiguration<TransportBooking>
    {
        public void Configure(EntityTypeBuilder<TransportBooking> builder)
        {
            builder.HasKey(tb => new { tb.TourId, tb.TransportId });
            builder.Property(tb => tb.Origin)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(b => b.Price).HasPrecision(2);

            builder.Property(tb => tb.Destination)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(tb => tb.DepartureTime)
                   .IsRequired();

            builder.Property(tb => tb.ArrivalTime)
                   .IsRequired();

            builder.HasData(
                new TransportBooking
                {
                    TourId = 1,
                    TransportId = 1,
                    Origin = "Abuja",
                    Destination = "Lagos",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 5000
                },
                new TransportBooking
                {
                    TourId = 2,
                    TransportId = 2,
                    Origin = "Lagos",
                    Destination = "Abuja",
                    DepartureTime = new DateTime(2024, 12, 2, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 2, 12, 0, 0),
                    Price = 5000
                }
            );
        }
    }
}