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

            builder.Property(b => b.Price)
                   .IsRequired();

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
                    Origin = "Toronto",
                    Destination = "Niagara Falls",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 100
                },
                new TransportBooking
                {
                    TourId = 3,
                    TransportId = 3,
                    Origin = "Las Vegas",
                    Destination = "Grand Canyon",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 4,
                    TransportId = 4,
                    Origin = "Las Vegas",
                    Destination = "Horseshoe Bend",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 5,
                    TransportId = 5,
                    Origin = "Las Vegas",
                    Destination = "Lake Powell",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 6,
                    TransportId = 6,
                    Origin = "Washington DC",
                    Destination = "Yellowstone National Park",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 7,
                    TransportId = 7,
                    Origin = "San Francisco",
                    Destination = "Yosemite Valley",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 8,
                    TransportId = 8,
                    Origin = "New York",
                    Destination = "The Narrows",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 9,
                    TransportId = 9,
                    Origin = "Las Vegas",
                    Destination = "Bryce Canyon National Park",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 10,
                    TransportId = 10,
                    Origin = "California",
                    Destination = "Monument Valley",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 11,
                    TransportId = 11,
                    Origin = "Las Vegas",
                    Destination = "Arches National Park",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                },
                new TransportBooking
                {
                    TourId = 12,
                    TransportId = 12,
                    Origin = "Washington DC",
                    Destination = "Canyonlands National Park",
                    DepartureTime = new DateTime(2024, 12, 1, 8, 0, 0),
                    ArrivalTime = new DateTime(2024, 12, 1, 12, 0, 0),
                    Price = 200
                }
            );
        }
    }
}