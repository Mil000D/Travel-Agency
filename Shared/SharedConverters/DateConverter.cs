namespace MASProject.Shared.SharedConverters
{
    public static class DateConverter
    {
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
