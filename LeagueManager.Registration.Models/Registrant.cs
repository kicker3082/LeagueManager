using LeagueManager.Shared.Models;
using System.Collections.Generic;

namespace LeagueManager.Registration.Models
{
    public class Registrant : Player
    {
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}