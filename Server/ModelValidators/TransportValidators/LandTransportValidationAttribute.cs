using MASProject.Server.Models.TransportModels;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Validators.TransportValidators
{
    public class LandTransportValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var transport = (Transport)validationContext.ObjectInstance;
            if (transport.TransportType == Enums.TransportType.Land && value == null)
            {
                return new ValidationResult($"{validationContext.DisplayName} is required for Land Transports.");
            }

            if (transport.TransportType != Enums.TransportType.Land && value != null)
            {
                return new ValidationResult($"{validationContext.DisplayName} should not be set for non Land Transports.");
            }
            return ValidationResult.Success;
        }
    }
}
