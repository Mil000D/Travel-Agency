using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.TourModels;
using MASProject.Server.Models.TransportModels;
using MASProject.Server.Models.UserModels;

namespace MASProject.Tests
{
    public class TourPurchaseTests
    {
        [Fact]
        public void TestTotalPrice()
        {
            var customer = new Customer
            {
                Id = 1,
                Username = "JohnDoe",
                Password = "password",
                Name = "John Doe",
                Surname = "Doe",


            };
        }
    }
}
