using MASProject.Server.Models.TransportModels;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Validators.TransportValidators
{
    /// <summary>
    /// Custom validation attribute to validate properties specific to Air transport.
    /// </summary>
    public class AirTransportValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var transport = (Transport)validationContext.ObjectInstance;
            if (transport.TransportType == Enums.TransportType.Air && value == null)
            {
                return new ValidationResult($"{validationContext.DisplayName} is required for Air Transports.");
            }

            if (transport.TransportType != Enums.TransportType.Air && value != null)
            {
                return new ValidationResult($"{validationContext.DisplayName} should not be set for non Air Transports.");
            }

            return ValidationResult.Success;
        }
    }
}
