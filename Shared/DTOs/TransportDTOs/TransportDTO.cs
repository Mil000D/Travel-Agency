using System.ComponentModel.DataAnnotations;
using MASProject.Shared.DTOs.LodgingDTOs;

namespace MASProject.Shared.DTOs.TransportDTOs
{
    public class TransportDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = null!;
        public override bool Equals(object? o)
        {
            var other = o as LodgingDTO;
            return other?.Name == Name;
        }
        public override int GetHashCode() => Name.GetHashCode();
    }
}
