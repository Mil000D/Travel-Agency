using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MASProject.Server.Converters
{
    public class ListOfStringsConverter : ValueConverter<List<string>, string>
    {
        public ListOfStringsConverter(string delimiter)
            : base(
                v => string.Join(delimiter, v),
                v => v.Split(new[] { delimiter }, StringSplitOptions.None).ToList())
        {
        }
    }

    public class ListOfStringsConverterNullable : ValueConverter<List<string>?, string?>
    {
        public ListOfStringsConverterNullable(string delimiter)
            : base(
                v => v == null ? null : string.Join(delimiter, v),
                v => string.IsNullOrEmpty(v) ? null : v.Split(new[] { delimiter }, StringSplitOptions.None).ToList())
        {
        }
    }
}
