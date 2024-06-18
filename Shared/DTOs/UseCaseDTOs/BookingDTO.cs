using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public abstract class BookingDTO
    {
        [Required]
        [Range(1f, float.MaxValue, ErrorMessage = "The field Price must be positive.")]
        public float Price { get; set; }
    }
}
