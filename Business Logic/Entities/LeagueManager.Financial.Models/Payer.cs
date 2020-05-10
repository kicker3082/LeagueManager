
using System;
using LeagueManager.Shared.Models;

namespace LeagueManager.Financial.Models
{
    public class Payer : IPerson
    {
        PersonName IPerson.Name { get; set; }
        DateTime? IPerson.DOB { get; set; }
    }
}
