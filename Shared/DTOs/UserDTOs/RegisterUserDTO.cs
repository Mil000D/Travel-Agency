namespace MASProject.Shared.DTOs.UserDTOs
{
    public class RegisterUserDTO
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime? BirthDate { get; set; } = DateTime.Today;
    }
}
