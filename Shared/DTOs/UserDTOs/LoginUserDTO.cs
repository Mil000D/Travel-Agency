using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UserDTOs
{
    public class LoginUserDTO
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Login { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
