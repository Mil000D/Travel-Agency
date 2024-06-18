using MASProject.Server.Models.TourModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace MASProject.Server.Configurations
{
    public class TourPurchaseEntityTypeConfiguration : IEntityTypeConfiguration<TourPurchase>
    {
        public void Configure(EntityTypeBuilder<TourPurchase> builder)
        {
            builder.HasKey(tb => new { tb.TourId, tb.CustomerId });

            builder.Property(tp => tp.PaymentMethod)
                   .IsRequired();

            builder.Property(tp => tp.PaymentDate)
                   .IsRequired();

            builder.Property(tp => tp.TourStatus)
                    .IsRequired();

            builder.HasData(
                new TourPurchase
                {
                    TourId = 1,
                    CustomerId = 1,
                    PaymentMethod = Enums.PaymentMethod.Card,
                    PaymentDate = new DateOnly(2024, 10, 1),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 2,
                    CustomerId = 2,
                    PaymentMethod = Enums.PaymentMethod.Cash,
                    PaymentDate = new DateOnly(2024, 9, 2),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 3,
                    CustomerId = 3,
                    PaymentMethod = Enums.PaymentMethod.BLIK,
                    PaymentDate = new DateOnly(2024, 8, 3),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 4,
                    CustomerId = 4,
                    PaymentMethod = Enums.PaymentMethod.Card,
                    PaymentDate = new DateOnly(2024, 7, 4),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 5,
                    CustomerId = 4,
                    PaymentMethod = Enums.PaymentMethod.Cash,
                    PaymentDate = new DateOnly(2024, 8, 5),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 6,
                    CustomerId = 3,
                    PaymentMethod = Enums.PaymentMethod.BLIK,
                    PaymentDate = new DateOnly(2024, 9, 6),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 7,
                    CustomerId = 2,
                    PaymentMethod = Enums.PaymentMethod.Card,
                    PaymentDate = new DateOnly(2024, 10, 7),
                    TourStatus = Enums.TourStatus.Booked
                },
                new TourPurchase
                {
                    TourId = 8,
                    CustomerId = 1,
                    PaymentMethod = Enums.PaymentMethod.Cash,
                    PaymentDate = new DateOnly(2024, 11, 8),
                    TourStatus = Enums.TourStatus.Booked
                }
            );
        }
    }
}
