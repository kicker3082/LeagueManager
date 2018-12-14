using LeagueManager.Registration.Operations.EF;
using LeagueManager.Registration.Operations;
using System;

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
    public class RegistrationFixture_RegisterPlayerForSeason
    {
        // Registration Scenarios:
        //  1. Attempt to register player
        //      A. Registration closed - return 


        [TestInitialize]
        public void Setup()
        {
            // Configure for live registration with in-Memory database
            // Configure season
            // Set clock
            // 
        }

        [TestMethod]
        public void RegisterPlayerForSeason_AgeOutOfRange_ReturnsAgeOutOfRangeRegistration()
        {

        }

        [TestMethod]
        public void RegisterPlayerForSeason_RegistrationClosed_ReturnsRegistrationClosedRegistration()
        {

        }

        [TestMethod]
        public void RegisterPlayerForSeason_SeasonAlreadyStarted_ReturnsSeasonStartedRegistration()
        {

        }
    }
}