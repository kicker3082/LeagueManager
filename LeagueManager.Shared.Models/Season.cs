using System;

namespace LeagueManager.Shared.Models
{
    public class Season
    {
        public string SeasonOfTheYear { get; set; }
        public int Year { get; set; }
        public DateTime RegistrationOpenOn { get; set; }
        public DateTime RegistrationClosedOn { get; set; }
        public DateTime RostersFinalizedOn { get; set; }
    }
}