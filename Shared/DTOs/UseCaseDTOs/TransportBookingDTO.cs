using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class TransportBookingDTO
    {
        public int Id { get; set; }
        [Required]
        public TransportDTO Transport { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Origin { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Destination { get; set; } = null!;
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(ArrivalTime), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateTime? DepartureTime { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(DepartureTime), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateTime? ArrivalTime { get; set; }
        [Required]
        [Range(1f, float.MaxValue)]
        public float Price { get; set; }
    }
}
