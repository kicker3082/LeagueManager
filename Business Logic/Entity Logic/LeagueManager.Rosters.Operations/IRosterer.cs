using System.Collections.Generic;
using LeagueManager.Leagues.Models;
using LeagueManager.Shared.Models;

namespace LeagueManager.Rosters.Operations
{
    public interface IRosterer
    {
        IEnumerable<ITeamPlayer> GetAllRosteredPlayersOnATeam(ITeam teamOfPlayers);
        IEnumerable<ITeamCoach> GetAllCoachesRosteredOnATeam(ITeam teamOfCoaches);
        ITeamPlayer AssignRegisteredPlayerToTeam(IPlayer playerToAssign, ITeam teamToAssignPlayerTo);
        void RemovePlayerFromTeam(ITeamPlayer playerToRemoveFromTeam);
        ITeamPlayer TransferPlayerFromOneTeamToAnother(ITeamPlayer playerToTransfer, ITeam newTeamOfPlayer);
        ITeamCoach AssignCoachToTeam(ICoach coachToAssign, ITeam teamToAssignCoachTo, ICoachRole roleOfCoachOnTeam);
        void RemoveCoachFromTeam(ITeamCoach teamCoachToRemove);
    }
}
