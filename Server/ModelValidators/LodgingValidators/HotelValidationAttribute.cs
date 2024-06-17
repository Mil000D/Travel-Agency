using MASProject.Server.Models.LodgingModels;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.ModelValidators.LodgingValidators
{
    public class HotelValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var lodging = (Lodging)validationContext.ObjectInstance;
            if (lodging.LodgingType == Enums.LodgingType.Hotel && value == null)
            {
                return new ValidationResult($"{validationContext.DisplayName} is required for Hotels.");
            }

            if (lodging.LodgingType == Enums.LodgingType.Inn && value != null)
            {
                return new ValidationResult($"{validationContext.DisplayName} should not be set for Inns.");
            }

            return ValidationResult.Success;
        }
    }
}
