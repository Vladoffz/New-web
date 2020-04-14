using System.Collections.Generic;
using System.Text;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryPlayer : ISyncRepository<int, Player>
    {
        List<Player> GetByTeamId(int itemCommandId);
    }
    public interface IRepositoryTeam : ISyncRepository<int, Command>
    {
        Command GetByName(string name);
    }
}
