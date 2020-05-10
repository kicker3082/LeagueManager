using System;
using System.Collections.Generic;
using LeagueManager.Leagues.Models;
using LeagueManager.Leagues.Operations;
using Moq;

#region Test

// ReSharper disable RedundantUsingDirective
#if !NUNIT
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Category = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;
using Assert = NUnit.Framework.Assert;
using Throws = NUnit.Framework.Throws;
using Is = NUnit.Framework.Is;

#else
 using NUnit.Framework;
 using TestClass = NUnit.Framework.TestFixtureAttribute;
 using TestMethod = NUnit.Framework.TestAttribute;
 using TestInitialize = NUnit.Framework.SetUpAttribute;
 using TestCleanup = NUnit.Framework.TearDownAttribute;
 using TestContext = System.Object;
#endif
// ReSharper restore RedundantUsingDirective

#endregion

namespace LeagueManager.Leagues.Tests
{
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public class LeagueOperatorDomainService_Fixture
    {
        private readonly List<ITeam> _createdTeams = new List<ITeam>();
        private ILeagueOperator _svc = ILeagueOperator.Null;

        [TestInitialize]
        public void Setup()
        {
            _svc = new LeagueOperatorDomainService(() => new Team());
        }

        [TestCleanup]
        public void Cleanup()
        {
            _createdTeams.ForEach(_svc.RemoveTeamFromLeague);

            //_createdTeams.ForEach(team =>
            //    {
            //        try
            //        {
            //            _svc.RemoveTeamFromLeague(team);
            //        }
            //        // ReSharper disable once EmptyGeneralCatchClause
            //        catch
            //        {
            //        }
            //    }
            //);
        }

        private ITeam CreateNewTeamAndAddToList(ILeague league, string nameOfNewTeam)
        {
            var team = _svc.CreateNewTeamInLeague(league, nameOfNewTeam);
            _createdTeams.Add(team);
            return team;
        }

        private void RemoveTeamAndRemoveFromList(ITeam teamToRemove)
        {
            _svc.RemoveTeamFromLeague(teamToRemove);
            _createdTeams.Remove(teamToRemove);
        }

        [TestMethod]
        public void RemoveTeam_TeamDoesNotExist_Throws()
        {
            var league = _svc.CreateNewLeague("My Happy League");
            var team = CreateNewTeamAndAddToList(league, "Happy Team Full Of Happy Players");
            RemoveTeamAndRemoveFromList(team);

            var ex = Assert.Throws<InvalidOperationException>(() => _svc.RemoveTeamFromLeague(team));

            Assert.That(ex.Message, Is.EqualTo(LeagueOperatorDomainService.Strings.TeamOfNameDoesNotExist));
        }

        [TestMethod]
        public void CreateNewTeam_TeamDoesNotAlreadExist_TeamCreated()
        {
            var league = _svc.CreateNewLeague("My Happy League");
            var team = CreateNewTeamAndAddToList(league, "Happy Team Full Of Happy Players");

            Assert.That(team, Is.Not.Null);
        }

        [TestMethod]
        public void CreateNewTeam_TeamDoesNotAlreadExist_TeamCreated_WithSameName()
        {
            const string teamName = "Happy Team Full Of Happy Players";
            var league = _svc.CreateNewLeague("My Happy League");
            var team = CreateNewTeamAndAddToList(league, teamName);

            Assert.That(team.Name, Is.EqualTo(teamName));
        }

        [TestMethod]
        public void CreateNewTeam_TeamWithSameNameAlreadyExists_Throws()
        {
            const string teamName = "Happy Team Full Of Happy Players";
            var league = _svc.CreateNewLeague("My Happy League");
            CreateNewTeamAndAddToList(league, teamName);

            var ex = Assert.Throws<InvalidOperationException>(() => _svc.CreateNewTeamInLeague(league, teamName));

            Assert.That(ex.Message, Is.EqualTo(LeagueOperatorDomainService.Strings.TeamWithNameAlreadyExists));
        }

        [TestMethod]
        public void CreateNewLeague_LeagueNameEmpty_Throws()
        {
            var ex = Assert.Throws<ArgumentException>(() => _svc.CreateNewLeague(string.Empty));

            Assert.That(ex.ParamName, Is.EqualTo("nameOfNewLeague"));
            Assert.That(ex.Message.StartsWith(LeagueOperatorDomainService.Strings.LeagueNameEmptyErrorMessage, StringComparison.CurrentCulture));
        }
        private class Team : ITeam
        {
            public Team()
            {
                LeagueOfTeam = new League();
                Name = string.Empty;
                Players = new ITeamPlayer[0];
            }

            public ILeague LeagueOfTeam { get; set; }
            public string Name { get; set; }
            public ICollection<ITeamPlayer> Players { get; set; }
        }
        private class League : ILeague
        {
            public League()
            {
                Id = default;
                Name = string.Empty;
                TeamsWithinLeague = new ITeam[0];
            }
            public int Id { get; set; }
            public string Name { get; set; }
            public ICollection<ITeam> TeamsWithinLeague { get; set; }
        }
    }
}
