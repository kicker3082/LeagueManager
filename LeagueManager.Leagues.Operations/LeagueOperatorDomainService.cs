using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using LeagueManager.Leagues.Models;

namespace LeagueManager.Leagues.Operations
{
    public class LeagueOperatorDomainService : ILeagueOperator
    {
        #region Strings
        public static class Strings
        {
            public static readonly string LeagueNameEmptyErrorMessage = @"The name cannot be empty.";
            public static readonly string TeamWithNameAlreadyExists = @"A team with that name already exists.";
            public static readonly string TeamOfNameDoesNotExist = @"That team does not exist.";
        }

        #endregion

        static readonly ConcurrentDictionary<string, Team> Teams = new ConcurrentDictionary<string, Team>();
        LeagueOperatorDomainService() { }
        public static ILeagueOperator NewService()
        {
            return new LeagueOperatorDomainService();
        }

        League ILeagueOperator.CreateNewLeague(string nameOfNewLeague)
        {
            if (nameOfNewLeague == null)
                throw new ArgumentNullException(nameof(nameOfNewLeague));

            if (nameOfNewLeague.Length == 0)
                throw new ArgumentException(Strings.LeagueNameEmptyErrorMessage, nameof(nameOfNewLeague));

            return null;
        }

        Team ILeagueOperator.CreateNewTeamInLeague(League leagueToCreateNewTeamIn, string nameOfNewTeam)
        {
            var newTeam = new Team
            {
                Name = nameOfNewTeam
            };
            if (!Teams.TryAdd(nameOfNewTeam, newTeam))
                throw new InvalidOperationException(Strings.TeamWithNameAlreadyExists);

            return newTeam;
        }

        void ILeagueOperator.RemoveTeamFromLeague(Team teamToRemoveFromLeague)
        {
            Team removedTeam;
            if (!Teams.TryRemove(teamToRemoveFromLeague.Name, out removedTeam))
                throw new InvalidOperationException(Strings.TeamOfNameDoesNotExist);
        }
    }
}