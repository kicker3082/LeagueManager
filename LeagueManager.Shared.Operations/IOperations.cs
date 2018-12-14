using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Shared.Operations
{
    public interface IOperations
    {
        Player CreateNewPlayer(PersonName name, DateTime dob, Gender gender);
        void RemovePlayer(Player playerToRemove);
    }
}
