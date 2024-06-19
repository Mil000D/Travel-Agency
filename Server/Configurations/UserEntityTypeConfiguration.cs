using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    /// <summary>
    /// Configuration class for the User entity type.
    /// </summary>
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        /// <summary>
        /// Configures the User entity.
        /// </summary>
        /// <param name="builder">The builder used to configure the User entity.</param>
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.Password)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.Surname)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.BirthDate)
                   .IsRequired();
        }
    }
}
