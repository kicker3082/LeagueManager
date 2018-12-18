
using System;
using LeagueManager.Shared.Models;

namespace LeagueManager.Financial.Models
{
    public class Payer : IPerson
    {
        PersonName IPerson.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime? IPerson.DOB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
