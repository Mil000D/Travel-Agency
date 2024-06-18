using MASProject.Server.Models.SharedModels;
using MASProject.Server.Models.TourModels;
using MASProject.Server.ModelValidators.Shared;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TransportModels
{
    public class TransportBooking : Booking
    {
        [Required]
        public int TransportId { get; set; }
        public Transport Transport { get; set; } = null!;
        [Required]
        public int TourId { get; set; }
        [Required]
        public Tour Tour { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Origin { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Destination { get; set; } = null!;
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(ArrivalTime), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateTime DepartureTime { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(DepartureTime), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateTime ArrivalTime { get; set; }
    }
}
