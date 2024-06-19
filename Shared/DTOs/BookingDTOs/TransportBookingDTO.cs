using MASProject.Shared.DTOs.TransportDTOs;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.BookingDTOs
{
    public class TransportBookingDTO : BookingDTO
    {
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
        [IntervalDateValidation(nameof(ArrivalTime), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateTime? DepartureTime { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(DepartureTime), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateTime? ArrivalTime { get; set; }
    }
}
