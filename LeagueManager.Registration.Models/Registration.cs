using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Registration.Models
{
    /// <summary>
    /// The event that occurs when a Registrant registers for a league.
    /// </summary>
    public class Registration
    {
        public int Id { get; set; }
        public Player RegisteredPlayer { get; set; }
        public DateTime RegisteredOn { get; set; }

    }
}
