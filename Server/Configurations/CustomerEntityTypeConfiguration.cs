using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    /// <summary>
    /// Configuration class for the Customer entity type.
    /// </summary>
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        /// <summary>
        /// Configures the Customer entity.
        /// </summary>
        /// <param name="builder">The builder used to configure the Customer entity.</param>
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Username = "johndoe",
                    Password = "password",
                    Name = "John",
                    Surname = "Doe",
                    Email = "john@doe.com",
                    PhoneNumber = "123456789"
                },
                new Customer
                {
                    Id = 2,
                    Username = "janedoe",
                    Password = "password",
                    Name = "Jane",
                    Surname = "Doe",
                    Email = "jane@doe.com",
                    PhoneNumber = "987654321"
                },
                new Customer
                {
                    Id = 3,
                    Username = "alicesmith",
                    Password = "password",
                    Name = "Alice",
                    Surname = "Smith",
                    Email = "alice@smith.com",
                    PhoneNumber = "123123123"
                },
                new Customer
                {
                    Id = 4,
                    Username = "bobsmith",
                    Password = "password",
                    Name = "Bob",
                    Surname = "Smith",
                    Email = "bob@smith.com",
                    PhoneNumber = "456456456"
                }
            );
        }
    }
}
