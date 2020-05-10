using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Registration.Models
{
    /// <summary>
    /// The event that occurs when a Registrant registers for a league.
    /// </summary>
    public interface IRegistration
    {
        IPlayer RegisteredPlayer { get; set; }
        DateTime RegisteredOn { get; set; }
        /// <summary>
        /// Returns an object that represents a null value
        /// </summary>
        public static IRegistration Null => NullRegistration.Get();
    }

    /// <summary>
    /// Represents a null IRegistration
    /// </summary>
    public sealed class NullRegistration : IRegistration
    {
        private NullRegistration() { }
        IPlayer IRegistration.RegisteredPlayer { get => IPlayer.Null; set { } }
        DateTime IRegistration.RegisteredOn { get => default; set { } }
        private readonly static NullRegistration _single = new NullRegistration();
        public static NullRegistration Get() => _single;
    }
}
