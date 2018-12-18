using LeagueManager.Shared.Models;

namespace LeagueManager.Leagues.Models
{
    public interface ITeamCoach : ICoach
    {
        ITeam Team { get; set; }
        string JerseyNumber { get; set; }
    }
}