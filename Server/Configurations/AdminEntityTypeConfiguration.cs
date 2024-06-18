using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    public class AdminEntityTypeConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(
               new Admin
               {
                   Id = 5,
                   Username = "adminryan",
                   Password = "password",
                   Name = "Ryan",
                   Surname = "Doe",
               },
               new Admin
               {
                   Id = 6,
                   Username = "admindoe",
                   Password = "password",
                   Name = "Jack",
                   Surname = "Doe",
               },
               new Admin
               {
                   Id = 7,
                   Username = "adminalice",
                   Password = "password",
                   Name = "Alice",
                   Surname = "Doe",
               },
               new Admin
               {
                   Id = 8,
                   Username = "adminethan",
                   Password = "password",
                   Name = "Ethan",
                   Surname = "Smith",
               }
           );
        }
    }
}
