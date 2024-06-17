using MASProject.Server.Comparers;
using MASProject.Server.Converters;
using MASProject.Server.Models.LodgingModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    public class LodgingEntityTypeConfiguration : IEntityTypeConfiguration<Lodging>
    {
        public void Configure(EntityTypeBuilder<Lodging> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(l => l.Address)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(l => l.Description)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(l => l.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(l => l.Email)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(l => l.Owner)
                   .HasMaxLength(50);

            builder.Property(l => l.Stars)
                   .IsRequired(false);

            builder.Property(l => l.OfficialWebsiteURL)
                   .HasMaxLength(100);

            builder.Property(l => l.Amenities)
                   .IsRequired(false)
                   .HasConversion(new ListOfStringsConverterNullable("#"))
                   .Metadata.SetValueComparer(new ListOfStringsComparer());

            builder.Property(l => l.PetFriendly)
                   .IsRequired(false);

            builder.Property(l => l.BreakfastIncluded)
                   .IsRequired(false);

            builder.Property(l => l.LodgingType)
                   .IsRequired();

            builder.HasData(
                new Lodging
                {
                    Id = 1,
                    Name = "Hotel 1",
                    Address = "Address 1",
                    Description = "Description 1",
                    PhoneNumber = "2321231123",
                    Email = "hotel@example.com"
                },
                new Lodging
                {
                    Id = 2,
                    Name = "Hotel 2",
                    Address = "Address 2",
                    Description = "Description 2",
                    PhoneNumber = "3232323222",
                    Email = "hotelnew@example.com"
                },
                new Lodging
                {
                    Id = 3,
                    Name = "Inn 1",
                    Address = "Address 3",
                    Description = "Description 3",
                    PhoneNumber = "098776512",
                    Email = "inn@example.com"
                },
                new Lodging
                {
                    Id = 4,
                    Name = "Inn 2",
                    Address = "Address 4",
                    Description = "Description 4",
                    PhoneNumber = "3232323232",
                    Email = "innnew@example.com"
                }
            );
        }
    }
}
