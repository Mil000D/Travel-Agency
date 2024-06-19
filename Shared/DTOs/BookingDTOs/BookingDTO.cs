using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.BookingDTOs
{
    public abstract class BookingDTO
    {
        [Required]
        [Range(1f, float.MaxValue, ErrorMessage = "The field Price must be positive.")]
        public float Price { get; set; }
    }
}
