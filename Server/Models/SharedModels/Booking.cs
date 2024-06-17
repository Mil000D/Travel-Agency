using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.SharedModels
{
    public abstract class Booking
    {
        [Required]
        [Range(1f, float.MaxValue)]
        public float Price { get; set; }
    }
}
