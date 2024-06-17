using MASProject.Server.ModelValidators.Shared;
using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TransportModels
{
    public class Plane : Transport
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Model { get; set; } = null!;
        [Required]
        [AmenityValidation]
        [MinCollectionLength(1)]
        public List<string> Amenities { get; set; } = null!;
    }
}
