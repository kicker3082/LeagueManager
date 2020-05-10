using System;

namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// Represents a person. May be inherited by more concrete representations.
    /// </summary>
    public interface IPerson
    {
        PersonName Name { get; set; }
        // ReSharper disable once InconsistentNaming
        DateTime? DOB { get; set; }
        public static IPerson Null => NullPerson.Get();
    }

    public class NullPerson : IPerson
    {
        protected NullPerson() { }
        public PersonName Name { get => PersonName.Null; set { } }
        public DateTime? DOB { get => default; set { } }
        private readonly static NullPerson _single = new NullPerson();
        public static NullPerson Get() => _single;
    }
}