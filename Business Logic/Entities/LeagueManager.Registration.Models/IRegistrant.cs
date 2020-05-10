using LeagueManager.Shared.Models;
using System;
using System.Collections.Generic;

namespace LeagueManager.Registration.Models
{
    public interface IRegistrant : IPlayer
    {
        ICollection<IRegistration> Registrations { get; set; }
        new public static IRegistrant Null => NullRegistrant.Get();
    }

    public class NullRegistrant : IRegistrant
    {
        protected NullRegistrant() { }
        private readonly static NullRegistrant _single = new NullRegistrant();

        ICollection<IRegistration> IRegistrant.Registrations { get => _registrations; set { } }
        PersonName IPerson.Name { get => PersonName.Null; set { } }
        DateTime? IPerson.DOB { get => default; set { } }

        public static NullRegistrant Get() => _single;
        private readonly ICollection<IRegistration> _registrations = new IRegistration[0];
    }
}