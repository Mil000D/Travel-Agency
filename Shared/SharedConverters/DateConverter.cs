namespace MASProject.Shared.SharedConverters
{
    /// <summary>
    /// Static class for converting between different date types.
    /// </summary>
    public static class DateConverter
    {
        /// <summary>
        /// Converts an object to a nullable DateTime.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <returns>A nullable DateTime if the conversion is successful. Otherwise - null.</returns>
        public static DateTime? ConvertToDateTime(object value)
        {
            if (value is DateTime dateTime)
            {
                return dateTime;
            }

            if (value is DateOnly dateOnly)
            {
                return dateOnly.ToDateTime(TimeOnly.MinValue);
            }

            return null;
        }

        /// <summary>
        /// Converts an object to a DateOnly.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <returns>A DateOnly representation of the date.</returns>
        public static DateOnly ConvertToDateOnly(object? value)
        {
            if (value is DateTime?)
            {
                value = (DateTime) value;
            }
            if(value is DateTime dateTime)
            {
                return DateOnly.FromDateTime(dateTime);
            }
            if (value is DateOnly dateOnly)
            {
                return dateOnly;
            }

            return DateOnly.MinValue;
        }
    }
}
