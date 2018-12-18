using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public interface ILeague
    {
        int Id { get; set; }
        string Name { get; set; }
        ICollection<ITeam> TeamsWithinLeague { get; set; }
    }
}
