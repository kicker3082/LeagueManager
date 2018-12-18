using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public interface ITeam
    {
        ILeague LeagueOfTeam { get; set; }

        string Name { get; set; }

        ICollection<ITeamPlayer> Players { get; }
    }
}