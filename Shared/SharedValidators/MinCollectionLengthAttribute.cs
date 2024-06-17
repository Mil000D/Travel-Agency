using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
    public class MinCollectionLengthAttribute : ValidationAttribute
    {
        private readonly int _minLength;

        public MinCollectionLengthAttribute(int minLength)
        {
            _minLength = minLength;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is ICollection collection && collection.Count >= _minLength)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"The collection must contain at least {_minLength} elements.");
        }
    }
}
