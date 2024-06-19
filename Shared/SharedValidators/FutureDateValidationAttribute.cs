using MASProject.Shared.SharedConverters;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
    /// <summary>
    /// Custom validation attribute to check if a date is in the future.
    /// </summary>
    public class FutureDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var dateValue = DateConverter.ConvertToDateTime(value);

            if (dateValue == null)
            {
                return new ValidationResult("Invalid date value.", new[] { validationContext.DisplayName });
            }

            if (dateValue < DateTime.Today)
            {
                return new ValidationResult($"The field {validationContext.DisplayName} cannot be set to date before today.", new[] { validationContext.DisplayName });
            }

            return ValidationResult.Success;
        }
    }
}
