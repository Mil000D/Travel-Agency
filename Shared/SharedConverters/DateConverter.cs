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
    }
}
