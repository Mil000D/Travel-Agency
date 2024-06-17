using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class UpdateTourDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Description { get; set; } = null!;
        [Required]
        [MinCollectionLength(1)]
        [ImageValidation(new[] { ".jpg", ".png" })]
        public List<string> ImagesURL { get; set; } = null!;
        [Required]
        [MinCollectionLength(1)]
        public ICollection<TransportBookingDTO> TransportBookings { get; set; } = null!;
        [Required]
        [MinCollectionLength(1)]
        public ICollection<LodgingBookingDTO> LodgingBookings { get; set; } = null!;
    }
}
