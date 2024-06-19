using MASProject.Server.Comparers;
using MASProject.Server.Converters;
using MASProject.Server.Models.TransportModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    /// <summary>
    /// Configuration class for the Plane entity type.
    /// </summary>
    public class PlaneEntityTypeConfiguration : IEntityTypeConfiguration<Plane>
    {
        /// <summary>
        /// Configures the Plane entity.
        /// </summary>
        /// <param name="builder">The builder used to configure the Plane entity.</param>
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.Property(p => p.Model)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.Amenities)
                   .IsRequired()
                   .HasConversion(new ListOfStringsConverter("#"))
                   .Metadata.SetValueComparer(new ListOfStringsComparer());

            builder.HasData(
                new Plane
                {
                    Id = 1,
                    Model = "Boeing 747",
                    Description = "The Boeing 747 is a large, long–range wide-body airliner designed and manufactured by Boeing Commercial Airplanes in the United States. It is among the world's most recognizable aircraft and was the first wide-body produced. Manufactured from 1968 to 2021, the 747 held the passenger capacity record for 37 years.",
                    Company = "Alaska Airlines",
                    Capacity = 660,
                    MaxSpeed = 614,
                    CargoCapacity = 875,
                    Amenities = new List<string> { "Wi-Fi", "In-flight entertainment", "Power outlets" },
                    TransportType = Enums.TransportType.Air
                },
                new Plane
                {
                    Id = 2,
                    Model = "Airbus A380",
                    Description = "The Airbus A380 is a wide-body aircraft manufactured by Airbus. It is the world's largest passenger airliner. Airbus studies started in 1988 and the project was announced in 1990 to challenge the dominance of the Boeing 747 in the long haul market.",
                    Company = "American Airlines",
                    Capacity = 853,
                    MaxSpeed = 587,
                    CargoCapacity = 1500,
                    Amenities = new List<string> { "Wi-Fi", "In-flight entertainment", "Power outlets" },
                    TransportType = Enums.TransportType.Air
                },
                new Plane
                {
                    Id = 3,
                    Model = "Boeing 777",
                    Description = "The Boeing 777 is a wide-body airliner developed and manufactured by Boeing Commercial Airplanes. It is the world's largest twinjet. The 777 was designed to bridge the gap between Boeing's other wide-body airliners and the 747.",
                    Company = "Allegiant Air",
                    Capacity = 550,
                    MaxSpeed = 590,
                    CargoCapacity = 1000,
                    Amenities = new List<string> { "Wi-Fi", "In-flight entertainment", "Power outlets" },
                    TransportType = Enums.TransportType.Air
                },
                new Plane
                {
                    Id = 4,
                    Model = "Airbus A350",
                    Description = "The Airbus A350 is a long-range, wide-body jet airliner developed by Airbus. The A350 is the first Airbus aircraft with both fuselage and wing structures made primarily of carbon-fibre-reinforced polymer. Its variants seat 280 to 366 passengers in typical three-class seating layouts.",
                    Company = "American Airlines",
                    Capacity = 440,
                    MaxSpeed = 567,
                    CargoCapacity = 1000,
                    Amenities = new List<string> { "Wi-Fi", "In-flight entertainment", "Power outlets" },
                    TransportType = Enums.TransportType.Air
                },
                new Plane
                {
                    Id = 5,
                    Model = "Boeing 787",
                    Description = "The Boeing 787 Dreamliner is an American wide-body jet airliner manufactured by Boeing Commercial Airplanes. Launched in April 2004, the 787 was designed to be more fuel-efficient than the Boeing 767, which it was intended to replace. The 787 Dreamliner's distinguishing features include mostly electrical flight systems, raked wingtips, and noise-reducing chevrons on its engine nacelles.",
                    Company = "Frontier Airlines",
                    Capacity = 330,
                    MaxSpeed = 593,
                    CargoCapacity = 1000,
                    Amenities = new List<string> { "Wi-Fi", "In-flight entertainment", "Power outlets" },
                    TransportType = Enums.TransportType.Air
                }
            );
        }
    }
}
