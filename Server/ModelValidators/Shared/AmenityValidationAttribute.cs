using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.ModelValidators.Shared
{
    public class AmenityValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var amenities = (List<string>)value;
            foreach (var amenity in amenities)
            {
                if (amenity.Contains("#"))
                {
                    return new ValidationResult($"{validationContext.DisplayName} should not contain #");
                }
            }

            return ValidationResult.Success;
        }
    }
}
