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

    }
}
