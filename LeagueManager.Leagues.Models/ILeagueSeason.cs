using LeagueManager.Shared.Models;

namespace LeagueManager.Leagues.Models
{
    public interface ILeagueSeason
    {
        ILeague League { get; set; }
        ISeason Season { get; set; }

    }
}
