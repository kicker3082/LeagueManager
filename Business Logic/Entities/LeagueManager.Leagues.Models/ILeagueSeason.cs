using LeagueManager.Shared.Models;
using System.Net;

namespace LeagueManager.Leagues.Models
{
    public interface ILeagueSeason
    {
        ILeague League { get; set; }
        ISeason Season { get; set; }
        public static ILeagueSeason Null => NullLeagueSeason.Get();
    }

    public class NullLeagueSeason : ILeagueSeason
    {
        protected NullLeagueSeason() { }
        private readonly static NullLeagueSeason _single = new NullLeagueSeason();

        ILeague ILeagueSeason.League { get => ILeague.Null; set { } }
        ISeason ILeagueSeason.Season { get => ISeason.Null; set { } }

        public static NullLeagueSeason Get() => _single;
    }
}
