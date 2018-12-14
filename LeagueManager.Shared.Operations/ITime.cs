using System;

namespace LeagueManager.Shared.Operations
{
    public interface ITime
    {
        DateTime GetUTCDateTime();
        DateTime GetLocalTime();
        DateTime GetTimeInTimeZone(string timezone);
    }
}
