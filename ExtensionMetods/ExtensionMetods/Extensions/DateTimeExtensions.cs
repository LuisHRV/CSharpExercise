using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExtensionMetods.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisobj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisobj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)+" hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)+ " days";
            }
        }
    }
}
