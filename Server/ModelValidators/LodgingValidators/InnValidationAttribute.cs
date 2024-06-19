using MASProject.Server.Models.LodgingModels;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.ModelValidators.LodgingValidators
{
    /// <summary>
    /// Custom validation attribute to validate properties specific to Inn.
    /// </summary>
    public class InnPropertyValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var lodging = (Lodging)validationContext.ObjectInstance;
            if (lodging.LodgingType == Enums.LodgingType.Inn && value == null)
            {
                return new ValidationResult($"{validationContext.DisplayName} is required for Inns.");
            }

            if (lodging.LodgingType == Enums.LodgingType.Hotel && value != null)
            {
                return new ValidationResult($"{validationContext.DisplayName} should not be set for Hotels.");
            }

            return ValidationResult.Success;
        }
    }
}
