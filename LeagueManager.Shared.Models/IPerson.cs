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

    }
}