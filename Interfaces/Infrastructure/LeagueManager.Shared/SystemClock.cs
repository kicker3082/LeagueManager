using LeagueManager.Shared.Operations;
using System;

namespace LeagueManager.Shared
{
    public class SystemClock : ITime
    {
        public DateTime GetUTCDateTime()
        {
            return DateTime.UtcNow;
        }
        public DateTime GetLocalTime()
        {
            return DateTime.Now;
        }
        public DateTime GetTimeInTimeZone(string timezone)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(GetUTCDateTime(), timezone);
        }
    }
}
