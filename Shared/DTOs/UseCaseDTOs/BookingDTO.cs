using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public abstract class BookingDTO
    {
        [Required]
        [Range(1f, float.MaxValue)]
        public float Price { get; set; }
    }
}
