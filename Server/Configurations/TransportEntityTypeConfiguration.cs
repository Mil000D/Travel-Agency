using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    /// <summary>
    /// Configuration class for the Transport entity type.
    /// </summary>
    public class TransportEntityTypeConfiguration : IEntityTypeConfiguration<Transport>
    {
        /// <summary>
        /// Configures the Transport entity.
        /// </summary>
        /// <param name="builder">The builder used to configure the Transport entity.</param>
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
