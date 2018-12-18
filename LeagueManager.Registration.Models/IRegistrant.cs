using LeagueManager.Shared.Models;
using System.Collections.Generic;

namespace LeagueManager.Registration.Models
{
    public interface IRegistrant : IPlayer
    {
        ICollection<IRegistration> Registrations { get; set; }
    }
}