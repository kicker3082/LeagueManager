using LeagueManager.Shared.Models;
using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public interface ILeaguePlayer : IPlayer
    {
        ILeague League { get; set; }
        ICollection<ITeamPlayer> TeamPlayers { get; set; }
    }
}