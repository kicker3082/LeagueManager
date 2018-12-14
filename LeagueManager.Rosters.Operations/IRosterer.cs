using System.Collections.Generic;
using LeagueManager.Leagues.Models;
using LeagueManager.Shared.Models;

namespace LeagueManager.Rosters.Operations
{
    public interface IRosterer
    {
        IEnumerable<TeamPlayer> GetAllRosteredPlayersOnATeam(Team teamOfPlayers);
        IEnumerable<TeamCoach> GetAllCoachesRosteredOnATeam(Team teamOfCoaches);
        TeamPlayer AssignRegisteredPlayerToTeam(Player playerToAssign, Team teamToAssignPlayerTo);
        void RemovePlayerFromTeam(TeamPlayer playerToRemoveFromTeam);
        TeamPlayer TransferPlayerFromOneTeamToAnother(TeamPlayer playerToTransfer, Team newTeamOfPlayer);
        TeamCoach AssignCoachToTeam(Coach coachToAssign, Team teamToAssignCoachTo, CoachRole roleOfCoachOnTeam);
        void RemoveCoachFromTeam(TeamCoach teamCoachToRemove);

    }
}
