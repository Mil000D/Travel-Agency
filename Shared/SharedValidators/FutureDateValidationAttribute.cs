using MASProject.Shared.SharedConverters;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
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
                return new ValidationResult("Invalid date value.");
            }

            if (dateValue < DateTime.Today)
            {
                return new ValidationResult($"{validationContext.DisplayName} cannot be before today.");
            }

            return ValidationResult.Success;
        }
    }
}
