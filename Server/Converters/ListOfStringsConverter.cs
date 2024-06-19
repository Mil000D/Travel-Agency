using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MASProject.Server.Converters
{
    /// <summary>
    /// Converter for converting a list of strings to a single string with a specified delimiter, and the other way around.
    /// </summary>
    public class ListOfStringsConverter : ValueConverter<List<string>, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfStringsConverter"/> class.
        /// </summary>
        /// <param name="delimiter">The delimiter used to join and split the strings.</param>
        public ListOfStringsConverter(string delimiter)
            : base(
                v => string.Join(delimiter, v),
                v => v.Split(new[] { delimiter }, StringSplitOptions.None).ToList())
        {
        }
    }

    /// <summary>
    /// Converter for converting a nullable list of strings to a single nullable string with a specified delimiter, and the other way around.
    /// </summary>
    public class ListOfStringsConverterNullable : ValueConverter<List<string>?, string?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfStringsConverterNullable"/> class.
        /// </summary>
        /// <param name="delimiter">The delimiter used to join and split the strings.</param>
        public ListOfStringsConverterNullable(string delimiter)
            : base(
                v => v == null ? null : string.Join(delimiter, v),
                v => string.IsNullOrEmpty(v) ? null : v.Split(new[] { delimiter }, StringSplitOptions.None).ToList())
        {
        }
    }
}
