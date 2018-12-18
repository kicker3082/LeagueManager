using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Shared.Operations
{
    public interface IOperations
    {
        IPlayer CreateNewPlayer(PersonName name, DateTime dob, IGender gender);
        void RemovePlayer(IPlayer playerToRemove);
    }
}
