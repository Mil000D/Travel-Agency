using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;

namespace MASProject.Server.Configurations
{
    public class TransportEntityTypeConfiguration : IEntityTypeConfiguration<Transport>
    {
        public void Configure(EntityTypeBuilder<Transport> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Description)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(t => t.Company)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(t => t.Capacity)
                   .IsRequired();

            builder.Property(t => t.AirConditioning)
                   .IsRequired(false);

            builder.Property(t => t.MaxSpeed)
                   .IsRequired(false);

            builder.Property(t => t.CargoCapacity)
                   .IsRequired(false);

            builder.Property(t => t.TransportType)
                   .IsRequired();
        }
    }
}
