using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.SharedValidators
{
    /// <summary>
    /// Custom validation attribute to check if image URLs have valid extensions and are not empty or contain whitespace.
    /// </summary>
    public class ImageValidationAttribute : ValidationAttribute
    {
        private readonly string[] _validExtensions;
        /// <summary>
        /// Constructor to initialize the valid extensions.
        /// </summary>
        public ImageValidationAttribute(string[] validExtensions)
        {
            _validExtensions = validExtensions;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            List<string>? imageUrls = null;

            if (value is string singleUrl)
            {
                imageUrls = new List<string> { singleUrl };
            }
            else if (value is List<string> urlList)
            {
                imageUrls = urlList;
            }
 
            if (imageUrls == null || imageUrls.Count == 0)
            {
                return new ValidationResult("The ImagesURL field is required.", new[] { validationContext.DisplayName });
            }

            foreach (var url in imageUrls)
            {
                if (string.IsNullOrWhiteSpace(url))
                {
                    return new ValidationResult("Image URLs cannot be empty or whitespace.");
                }

                if (url.Any(char.IsWhiteSpace))
                {
                    return new ValidationResult($"Invalid URL: {url}. Image URLs cannot contain whitespace.", new[] { validationContext.DisplayName });
                }

                if (!_validExtensions.Any(ext => url.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                {
                    string allowedExtensions = string.Join(", ", _validExtensions);
                    return new ValidationResult($"Invalid image extension for URL: {url}. Only {allowedExtensions} are allowed.", new[] { validationContext.DisplayName });
                }
            }

            return ValidationResult.Success;
        }
    }
}
