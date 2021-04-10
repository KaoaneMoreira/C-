using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp3.Extensions;

namespace ConsoleApp3.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if( duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + "days";
            }
        }
    }
}
