using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Team> TeamsWithinLeague { get; set; }
    }
}
