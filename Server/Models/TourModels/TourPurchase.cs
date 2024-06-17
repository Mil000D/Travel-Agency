using MASProject.Server.Enums;
using MASProject.Server.Models.UserModels;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TourModels
{
    public class TourPurchase
    {
        public int TourId { get; set; }
        [Required]
        public Tour Tour { get; set; } = null!;
        public int CustomerId { get; set; }
        [Required]
        public Customer Customer { get; set; } = null!;
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        [Required]
        [FutureDateValidation]
        public DateOnly PaymentDate { get; set; }
        public float TotalPrice
        {
            get
            {
                float totalPrice = 0;
                if(Tour.TransportBookings == null || Tour.LodgingBookings == null)
                {
                    return totalPrice;
                }
                foreach (var booking in Tour.TransportBookings)
                {
                    totalPrice += booking.Price;
                }
                foreach (var booking in Tour.LodgingBookings)
                {
                    totalPrice += booking.Price;
                }
                return totalPrice;
            }
        }
        public TourStatus TourStatus { get; set; }
    }
}
