namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// Contains a configuration of the season definitions 
    /// </summary>
    public class SeasonConfiguration
    {
        /// <summary>
        /// E.g. "Youth Soccer", "Adult Baseball"
        /// 
        /// This is the key
        /// </summary>
        public string ConfigurationName { get; set; }
        /// <summary>
        /// Used to valiate the creation of a new season for registraton. If the
        /// start and end date span is greater than this value, an error is
        /// generated.
        /// </summary>
        public int? MaxSeasonLengthInDays { get; set; }
        /// <summary>
        /// Used to valiate the creation of a new season for registraton. If the
        /// start and end date span is greater than this value, an error is
        /// generated.
        /// </summary>
        public int? MaxSeasonLengthInWeeks { get; set; }
        /// <summary>
        /// Used to valiate the creation of a new season for registraton. If the
        /// start and end date span is greater than this value, an error is
        /// generated.
        /// </summary>
        public int? MaxSeasonLengthInMonths { get; set; }
    }
}