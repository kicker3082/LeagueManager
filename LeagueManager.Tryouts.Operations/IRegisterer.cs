using LeagueManager.Shared.Models;
using LeagueManager.Tryouts.Models;

namespace LeagueManager.Tryouts.Operations
{
    public interface IRegisterer
    {
        TryoutPlayer RegisterForTryoutByAge(Player playerToRegister, Tryout tryoutToRegisterFor);
    }
}
