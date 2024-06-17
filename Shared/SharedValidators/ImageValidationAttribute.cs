using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
    public class ImageValidationAttribute : ValidationAttribute
    {
        private readonly string[] _validExtensions;

        public ImageValidationAttribute(string[] validExtensions)
        {
            _validExtensions = validExtensions;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var imageUrls = value as List<string>;

            if (imageUrls == null || imageUrls.Count == 0)
            {
                return new ValidationResult("The ImagesURL field is required.");
            }

            foreach (var url in imageUrls)
            {
                if (string.IsNullOrWhiteSpace(url))
                {
                    return new ValidationResult("Image URLs cannot be empty or whitespace.");
                }

                if (url.Any(char.IsWhiteSpace))
                {
                    return new ValidationResult($"Invalid URL: {url}. Image URLs cannot contain whitespace.");
                }

                if (!_validExtensions.Any(ext => url.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                {
                    string allowedExtensions = string.Join(", ", _validExtensions);
                    return new ValidationResult($"Invalid image extension for URL: {url}. Only {allowedExtensions} are allowed.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
