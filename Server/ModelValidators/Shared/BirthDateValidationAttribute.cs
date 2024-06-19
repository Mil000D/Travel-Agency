using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.ModelValidators.Shared
{
    /// <summary>
    /// Custom validation attribute to check if a birth date indicates that a person is at least 18 years old.
    /// </summary>
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
