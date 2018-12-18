using System;

namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// A season is one instance of a period in which a sport is active for registrations, teams, rosters, games, etc.
    /// </summary>
    public interface ISeason
    {
        /// <summary>
        /// Typically named after the season of the year with the year; e.g. Spring 2018 Regular Season, Fall 2018 Playoffs, etc.
        /// For seasons that span years, use the format: Winter 2018-2019 Regular Season.
        /// 
        /// This is the natural key
        /// </summary>
        string SeasonName { get; set; }
        /// <summary>
        /// The configuration settings that this season was created under.
        /// </summary>
        ISeasonConfiguration SeasonConfiguration { get; set; }
        /// <summary>
        /// This year number is used to sort the season. It is not part of the key. Set this to the
        /// year number of the season start date.
        /// </summary>
        int YearOfSeasonStart { get; set; }
        DateTime? RegistrationOpenOn { get; set; }
        DateTime? RegistrationClosedOn { get; set; }
        DateTime? PracticesStartedOn { get; set; }
        DateTime? PracticesEndOn { get; set; }
        DateTime? GamesStartOn { get; set; }
        DateTime? GamesEndOn { get; set; }
        DateTime? RostersFinalizedOn { get; set; }
    }
}