using FootballManager.Models;

namespace FootballManager.Bl.Abstract
{
    public interface ITeamPlayerService
    {
        DisplayTeamModel GetTeamsAndPlayers(string name);
        bool CheckTeamValid();
    }
}