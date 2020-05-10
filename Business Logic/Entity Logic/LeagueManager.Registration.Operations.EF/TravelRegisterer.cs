using LeagueManager.Leagues.Models;
using LeagueManager.Registration.Models;
using System;

namespace LeagueManager.Registration.Operations.EF
{
    public class TravelRegisterer : IRegisterer
    {
        void IRegisterer.Deregister(IRegistration registrationToDeregister)
        {
            return;
        }

        IRegistration IRegisterer.RegisterForLeagueByAge(
            IRegistrant personToRegister,
            ILeagueSeason leagueSeasonToRegisterFor)
        {
            return IRegistration.Null;
        }
    }
}
