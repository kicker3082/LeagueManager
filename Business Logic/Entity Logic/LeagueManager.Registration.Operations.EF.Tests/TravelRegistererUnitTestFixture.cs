using LeagueManager.Registration.Operations.EF;
using LeagueManager.Registration.Operations;
using System;
using LeagueManager.Registration.Models;
using LeagueManager.Leagues.Models;

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

namespace Tests
{
    [TestClass]
    public class TravelRegistererUnitTestFixture
    {
        [TestInitialize]
        public void Setup()
        {
        }

        [Ignore]
        [TestMethod]
        public void RegisterForLeagueByAge_NullPersonThrows()
        {
            var reg = (IRegisterer)new TravelRegisterer();
            var ex = Assert.Throws<ArgumentNullException>(() => reg.RegisterForLeagueByAge(IRegistrant.Null, ILeagueSeason.Null));
            Assert.That(ex, Is.Not.Null);
            Assert.That(ex.ParamName, Is.EqualTo("personToRegister"));
        }
    }
}