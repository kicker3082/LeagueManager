using System;

namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// A season is one instance of a period in which a sport is active for registrations, teams, rosters, games, etc.
    /// </summary>
    public class Season
    {
        /// <summary>
        /// Typically named after the season of the year with the year; e.g. Spring 2018 Regular Season, Fall 2018 Playoffs, etc.
        /// For seasons that span years, use the format: Winter 2018-2019 Regular Season.
        /// 
        /// This is the natural key
        /// </summary>
        public string SeasonName { get; set; }
        /// <summary>
        /// The configuration settings that this season was created under.
        /// </summary>
        public SeasonConfiguration SeasonConfiguration { get; set; }
        /// <summary>
        /// This year number is used to sort the season. It is not part of the key. Set this to the
        /// year number of the season start date.
        /// </summary>
        public int YearOfSeasonStart { get; set; }
        public DateTime? RegistrationOpenOn { get; set; }
        public DateTime? RegistrationClosedOn { get; set; }
        public DateTime? PracticesStartedOn { get; set; }
        public DateTime? PracticesEndOn { get; set; }
        public DateTime? GamesStartOn { get; set; }
        public DateTime? GamesEndOn { get; set; }
        public DateTime? RostersFinalizedOn { get; set; }
    }
}