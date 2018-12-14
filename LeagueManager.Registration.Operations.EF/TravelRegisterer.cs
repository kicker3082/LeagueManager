using LeagueManager.Leagues.Models;
using LeagueManager.Registration.Models;
using System;

namespace LeagueManager.Registration.Operations.EF
{
    public class TravelRegisterer : IRegisterer
    {
        Models.Registration IRegisterer.RegisterForLeagueByAge(
            Registrant personToRegister, 
            LeagueSeason leagueSeasonToRegisterFor)
        {
            if (personToRegister == null)
                throw new ArgumentNullException(nameof(personToRegister));
            if (leagueSeasonToRegisterFor == null)
                throw new ArgumentNullException(nameof(leagueSeasonToRegisterFor));

            throw new System.NotImplementedException();
        }
    }
}
