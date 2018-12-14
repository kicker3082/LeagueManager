using LeagueManager.Leagues.Models;
using LeagueManager.Registration.Models;

namespace LeagueManager.Registration.Operations
{
    public interface IRegisterer
    {
        /// <summary>
        /// Register a player (Registrant) for a league-season
        /// </summary>
        /// <param name="personToRegister"></param>
        /// <param name="leageSeasonToRegisterFor"></param>
        /// <returns>A new registration record</returns>
        Models.Registration RegisterForLeagueByAge(Registrant personToRegister, LeagueSeason leageSeasonToRegisterFor);
    }
}
