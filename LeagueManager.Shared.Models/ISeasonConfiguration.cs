namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// Contains a configuration of the season definitions 
    /// </summary>
    public interface ISeasonConfiguration
    {
        /// <summary>
        /// E.g. "Youth Soccer", "Adult Baseball"
        /// 
        /// This is the key
        /// </summary>
        string ConfigurationName { get; set; }
        /// <summary>
        /// Used to valiate the creation of a new season for registraton. If the
        /// start and end date span is greater than this value, an error is
        /// generated.
        /// </summary>
        int? MaxSeasonLengthInDays { get; set; }
        /// <summary>
        /// Used to valiate the creation of a new season for registraton. If the
        /// start and end date span is greater than this value, an error is
        /// generated.
        /// </summary>
        int? MaxSeasonLengthInWeeks { get; set; }
        /// <summary>
        /// Used to valiate the creation of a new season for registraton. If the
        /// start and end date span is greater than this value, an error is
        /// generated.
        /// </summary>
        int? MaxSeasonLengthInMonths { get; set; }
    }
}