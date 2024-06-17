using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class LodgingDTO
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
