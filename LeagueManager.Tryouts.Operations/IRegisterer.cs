using LeagueManager.Shared.Models;
using LeagueManager.Tryouts.Models;

namespace LeagueManager.Tryouts.Operations
{
    public interface IRegisterer
    {
        ITryoutPlayer RegisterForTryoutByAge(IPlayer playerToRegister, ITryout tryoutToRegisterFor);
    }
}
