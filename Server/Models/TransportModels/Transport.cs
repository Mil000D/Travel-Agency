using MASProject.Server.Enums;
using MASProject.Server.Validators.TransportValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TransportModels
{
    public abstract class Transport
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Description { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Company { get; set; } = null!;
        [Required]
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }
        [LandTransportValidation]
        public bool? AirConditioning { get; set; }
        [AirTransportValidation]
        public int? MaxSpeed { get; set; }
        [AirTransportValidation]
        public int? CargoCapacity { get; set; }
        [Required]
        public TransportType TransportType { get; set; }
        public ICollection<TransportBooking>? TransportBookings { get; set; }
    }
}
