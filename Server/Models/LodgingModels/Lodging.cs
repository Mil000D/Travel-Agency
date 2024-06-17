using MASProject.Server.Enums;
using MASProject.Server.ModelValidators.LodgingValidators;
using MASProject.Server.ModelValidators.Shared;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.LodgingModels
{
    public class Lodging
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; } = null!;
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Description { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 7)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 5)]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [StringLength(50, MinimumLength = 1)]
        public string? Owner { get; set; }
        [Range(1, 5)]
        public int? Stars { get; set; }
        [HotelValidation]
        public string? OfficialWebsiteURL { get; set; }
        [AmenityValidation]
        [HotelValidation]
        public List<string>? Amenities { get; set; }
        [InnPropertyValidation]
        public bool? PetFriendly { get; set; }
        [InnPropertyValidation]
        public bool? BreakfastIncluded { get; set; }
        [Required]
        public LodgingType LodgingType { get; set; }
        public ICollection<LodgingBooking>? LodgingBookings { get; set; }
    }
}
