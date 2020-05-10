namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// Contains a configuration of the season definitions
    /// </summary>
    public interface ISeasonConfiguration
    {
        /// <summary>
        /// <para>E.g. "Youth Soccer", "Adult Baseball"</para>
        /// <para>This is the key</para>
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
        public static ISeasonConfiguration Null => NullSeasonConfiguration.Get();
    }

    public class NullSeasonConfiguration : ISeasonConfiguration
    {
        protected NullSeasonConfiguration() { }
        private static readonly NullSeasonConfiguration _single = new NullSeasonConfiguration();

        string ISeasonConfiguration.ConfigurationName { get => string.Empty; set { } }
        int? ISeasonConfiguration.MaxSeasonLengthInDays { get => default; set { } }
        int? ISeasonConfiguration.MaxSeasonLengthInWeeks { get => default; set { } }
        int? ISeasonConfiguration.MaxSeasonLengthInMonths { get => default; set { } }

        public static NullSeasonConfiguration Get() => _single;
    }
}