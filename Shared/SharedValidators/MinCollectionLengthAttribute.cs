using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
    /// <summary>
    /// Custom validation attribute to check if a collection has specified minimum number of elements.
    /// </summary>
    public class MinCollectionLengthAttribute : ValidationAttribute
    {
        private readonly int _minLength;
        /// <summary>
        /// Constructor to initialize the minimum length of collection.
        /// </summary>
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
            return new ValidationResult($"The collection must contain at least {_minLength} elements.", new[] { validationContext.DisplayName });
        }
    }
}
