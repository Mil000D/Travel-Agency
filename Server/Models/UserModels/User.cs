using MASProject.Server.ModelValidators.Shared;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.UserModels
{
    public abstract class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Username { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Surname { get; set; } = null!;
        [Required]
        [BirthDateValidation]
        public DateOnly BirthDate { get; set; }
    }
}
