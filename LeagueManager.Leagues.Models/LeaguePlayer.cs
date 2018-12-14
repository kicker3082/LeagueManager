using LeagueManager.Shared.Models;
using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public class LeaguePlayer : Player
    {
        public League League { get; set; }
        public ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}