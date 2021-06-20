using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceApp.Infrastructure.Services.DateTime
{
    public class DateTimeService : IDateTimeService
    {
        private static string DisplayName = "(GMT-03:00) America/Sao Paulo";
        private static string StandardName = "Sao Paulo";
        private static TimeSpan Offset = new TimeSpan(-3, 0, 0);
        private static TimeZoneInfo ApplicationTimeZone = TimeZoneInfo.CreateCustomTimeZone(StandardName, Offset, DisplayName, DisplayName);

        public override System.DateTime Now()
        {
            return TimeZoneInfo.ConvertTime(System.DateTime.Now, ApplicationTimeZone);
        }
    }
}
