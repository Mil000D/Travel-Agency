using MASProject.Server.Models.SharedModels;
using MASProject.Server.Models.TourModels;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.LodgingModels
{
    public class LodgingBooking : Booking
    {
        [Required]
        public int LodgingId { get; set; }
        [Required]
        public Lodging Lodging { get; set; } = null!;
        [Required]
        public int TourId { get; set; }
        [Required]
        public Tour Tour { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string RoomType { get; set; } = null!;
        [Required]
        public int MaxCapacity { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(CheckOutDate), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateOnly CheckInDate { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(CheckInDate), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateOnly CheckOutDate { get; set; }
    }
}
