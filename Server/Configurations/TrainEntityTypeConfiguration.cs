using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    public class TrainEntityTypeConfiguration : IEntityTypeConfiguration<Train>
    {
        public void Configure(EntityTypeBuilder<Train> builder)
        {
            builder.Property(t => t.TrainNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(t => t.Classes)
                   .IsRequired();

            builder.HasData(
                new Train
                {
                    Id = 6,
                    Description = "This is a train",
                    Company = "Train Company",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "123",
                    Classes = 3,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 7,
                    Description = "This is a train 2",
                    Company = "Train Company 2",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "456",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                }
            );
        }
    }
}
