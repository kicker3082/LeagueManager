using System;

namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// Represents a person. May be inherited by more concrete representations.
    /// </summary>
    public abstract class Person
    {
        public PersonName Name { get; set; }
        // ReSharper disable once InconsistentNaming
        public DateTime? DOB { get; set; }

    }
}