using System;
using System.Reflection.Metadata.Ecma335;

namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// A season is one instance of a period in which a sport is active for registrations, teams, rosters, games, etc.
    /// </summary>
    public interface ISeason
    {
        /// <summary>
        /// <para>
        /// Typically named after the season of the year with the year; e.g. Spring 2018 Regular Season, Fall 2018 Playoffs, etc.
        /// For seasons that span years, use the format: Winter 2018-2019 Regular Season.
        /// </para>
        /// <para>This is the natural key</para>
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
        public static ISeason Null => NullSeason.Get();
    }

    public class NullSeason : ISeason
    {
        protected NullSeason() { }
        private static readonly NullSeason _single = new NullSeason();

        string ISeason.SeasonName { get => string.Empty; set { } }
        ISeasonConfiguration ISeason.SeasonConfiguration { get => ISeasonConfiguration.Null; set { } }
        int ISeason.YearOfSeasonStart { get => default; set { } }
        DateTime? ISeason.RegistrationOpenOn { get => default; set { } }
        DateTime? ISeason.RegistrationClosedOn { get => default; set { } }
        DateTime? ISeason.PracticesStartedOn { get => default; set { } }
        DateTime? ISeason.PracticesEndOn { get => default; set { } }
        DateTime? ISeason.GamesStartOn { get => default; set { } }
        DateTime? ISeason.GamesEndOn { get => default; set { } }
        DateTime? ISeason.RostersFinalizedOn { get => default; set { } }

        public static NullSeason Get() => _single;
    }
}