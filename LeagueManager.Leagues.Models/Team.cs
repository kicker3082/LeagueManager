using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public class Team
    {
        public int Id { get; set; }
        public League LeagueOfTeam { get; set; }

        public string Name { get; set; }

        public ICollection<TeamPlayer> Players { get; set; }
    }
}