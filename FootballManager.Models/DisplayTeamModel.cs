using System.Collections.Generic;

namespace FootballManager.Models
{
    public class DisplayTeamModel
    {
        public string TeamName { get; set; }
        public List<PlayerModel> Players { get; set; }
        public List<ChampionshipModel> PlayedAtChampionship { get; set; }
    }

    public class ChampionshipModel
    {
        public string Name { get; set; }
    }

    public class PlayerModel
    {
        public object Name { get; set; }
    }
}