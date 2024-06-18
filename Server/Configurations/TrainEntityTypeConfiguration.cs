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
                    Description = "The National Railroad Passenger Corporation, doing business as Amtrak (reporting marks AMTK, AMTZ), is the national passenger railroad company of the United States.",
                    Company = "Amtrak",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "Q621-5",
                    Classes = 3,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 7,
                    Description = "BNSF Railway (reporting mark BNSF) is the largest freight railroad in the United States. One of six North American Class I railroads, BNSF has 36,000 employees, 33,400 miles (53,800 km) of track in 28 states, and over 8,000 locomotives.",
                    Company = "BNSF Railway",
                    Capacity = 200,
                    AirConditioning = true,
                    TrainNumber = "S321-5",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 8,
                    Description = "The Union Pacific Railroad (reporting mark UP) is a Class I line haul freight railroad that operates 8,300 locomotives over 31,800 route-miles in 23 states west of Chicago and New Orleans.",
                    Company = "Union Railroad",
                    Capacity = 300,
                    AirConditioning = false,
                    TrainNumber = "U321-5",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 9,
                    Description = "The Canadian National Railway Company (reporting mark CN) is a Canadian Class I freight railway headquartered in Montreal, Quebec, which serves Canada and the Midwestern and Southern United States.",
                    Company = "Canadian Railway",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "C321-5",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 10,
                    Description = "The Kansas City Southern Railway Company (reporting mark KCS) is an American Class I railroad that operates over 3,300 route miles (5,300 km) in 10 states in the central and southern United States.",
                    Company = "Kansas Railway",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "K321-5",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 11,
                    Description = "The Norfolk Southern Railway (reporting mark NS) is a Class I freight railroad in the United States. With headquarters in Atlanta, Georgia, the company operates 19,420 route miles (31,250 km) in 22 eastern states, the District of Columbia, and has rights in Canada over the Albany to Montréal route of the Canadian Pacific Railway, and previously on CN from Buffalo to St. Thomas.",
                    Company = "Norfolk Railway",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "N321-5",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                },
                new Train
                {
                    Id = 12,
                    Description = "The CSX Transportation (reporting mark CSXT) is a Class I freight railroad operating in the eastern United States and the Canadian provinces of Ontario and Quebec. The railroad operates approximately 21,000 route miles (34,000 km) of track.",
                    Company = "CSX",
                    Capacity = 100,
                    AirConditioning = true,
                    TrainNumber = "C321-5",
                    Classes = 4,
                    TransportType = Enums.TransportType.Land
                }
            );
        }
    }
}
