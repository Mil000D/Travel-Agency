using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class LodgingBookingDTO
    {
        public int Id { get; set; }
        [Required]
        public LodgingDTO Lodging { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string RoomType { get; set; } = null!;
        [Required]
        public int MaxCapacity { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(CheckOutDate), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateTime? CheckInDate { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(CheckInDate), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateTime? CheckOutDate { get; set; }
        [Required]
        [Range(1f, float.MaxValue)]
        public float Price { get; set; }
    }
}
