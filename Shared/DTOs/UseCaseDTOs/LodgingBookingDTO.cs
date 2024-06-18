using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class LodgingBookingDTO : BookingDTO
    {
        [Required]
        public LodgingDTO Lodging { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string RoomType { get; set; } = null!;
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The field MaxCapacity must be positive.")]
        public int MaxCapacity { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(CheckOutDate), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateTime? CheckInDate { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(CheckInDate), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateTime? CheckOutDate { get; set; }
    }
}
