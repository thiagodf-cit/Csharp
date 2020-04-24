using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime timeObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(timeObj);

            if (duration.TotalHours < 24.0)
            {
                return duration
                    .TotalHours
                    .ToString("F1", CultureInfo.InvariantCulture)
                    + " hours";
            }
            else
            {
                return duration
                    .TotalDays
                    .ToString("F1", CultureInfo.InvariantCulture)
                    + " hours";
            }
        }
    }
}
