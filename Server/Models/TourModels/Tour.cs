using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TourModels
{
    public class Tour
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Description { get; set; } = null!;
        public int? Popularity { get; set; }
        [Required]
        [MinCollectionLength(1)]
        [ImageValidation(new[] {".jpg", ".png"})]
        public List<string> ImagesURL { get; set; } = null!;
        public float TotalPrice
        {
            get
            {
                float totalPrice = 0;
                if (TransportBookings == null || LodgingBookings == null)
                {
                    return totalPrice;
                }
                foreach (var booking in TransportBookings)
                {
                    totalPrice += booking.Price;
                }
                foreach (var booking in LodgingBookings)
                {
                    totalPrice += booking.Price;
                }
                return totalPrice;
            }
        }
        public ICollection<TourPurchase>? TourPurchases { get; set; }
        public ICollection<LodgingBooking>? LodgingBookings { get; set; }
        public ICollection<TransportBooking>? TransportBookings { get; set; }
    }
}
