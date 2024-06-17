using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.ModelValidators.Shared
{
    public class BirthDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var birthDate = (DateTime)value;

            if (birthDate.AddYears(18) > DateTime.Today)
            {
                return new ValidationResult("You must be at least 18 years old to register.");
            }

            return ValidationResult.Success;
        }
    }
}
