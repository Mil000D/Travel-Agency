using MASProject.Server.Models.SharedModels;
using MASProject.Server.Models.TourModels;
using MASProject.Server.ModelValidators.Shared;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TransportModels
{
    public class TransportBooking : Booking
    {
        public int TransportId { get; set; }
        [Required]
        public Transport Transport { get; set; } = null!;
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
        [IntervalDateValidation(nameof(ArrivalTime), IntervalDateValidationAttribute.ComparisonType.Before)]
        public DateTime DepartureTime { get; set; }
        [Required]
        [FutureDateValidation]
        [IntervalDateValidation(nameof(DepartureTime), IntervalDateValidationAttribute.ComparisonType.After)]
        public DateTime ArrivalTime { get; set; }
    }
}
