using MASProject.Shared.SharedConverters;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
    public class IntervalDateValidationAttribute : ValidationAttribute
    {
        private readonly string _comparisonProperty;
        private readonly ComparisonType _comparisonType;

        public enum ComparisonType
        {
            Before,
            After
        }

        public IntervalDateValidationAttribute(string comparisonProperty, ComparisonType comparisonType)
        {
            _comparisonProperty = comparisonProperty;
            _comparisonType = comparisonType;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var currentValue = DateConverter.ConvertToDateTime(value);

            var comparisonProperty = validationContext.ObjectType.GetProperty(_comparisonProperty);

            if (comparisonProperty == null)
                throw new ArgumentNullException($"Property {_comparisonProperty} not found.");

            var comparisonValue = DateConverter.ConvertToDateTime(comparisonProperty.GetValue(validationContext.ObjectInstance));

            if (currentValue == null)
            {
                return new ValidationResult("Invalid date value.", new[] { validationContext.DisplayName });
            }

            if (_comparisonType == ComparisonType.After && currentValue >= comparisonValue)
            {
                return new ValidationResult($"The field {validationContext.DisplayName} cannot be after {comparisonValue}.", new[] { validationContext.DisplayName });
            }

            if (_comparisonType == ComparisonType.Before && currentValue <= comparisonValue)
            {
                return new ValidationResult($"The field {validationContext.DisplayName} cannot be before {comparisonValue}.", new[] { validationContext.DisplayName });
            }

            return ValidationResult.Success;
        }
    }
}
