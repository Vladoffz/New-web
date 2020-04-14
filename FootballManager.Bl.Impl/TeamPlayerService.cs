using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.Bl.Abstract;
using FootballManager.Config;
using FootballManager.DAL.Abstract;
using FootballManager.Entities;
using FootballManager.Models;
using Microsoft.Extensions.Options;

namespace FootballManager.Bl.Impl
{
    public class TeamPlayerService : ITeamPlayerService
    {
        private readonly IRepositoryTeam _teamRepository;
        private readonly IRepositoryPlayer _playerRepository;
        private readonly IRepositoryChampionship _championshipRepository;
        private readonly MyCustomConfig _config;
        public TeamPlayerService(IOptions<MyCustomConfig> config)
        {
            _config = config.Value;
        }

        public DisplayTeamModel  GetTeamsAndPlayers(string name)
        {
            Command item =
                _teamRepository.GetByName(name);
            
            List<Player> players = 
                _playerRepository.GetByTeamId(item.CommandID);

            var championShip = 
                _championshipRepository.GetForCommand(item.CommandID);
            DisplayTeamModel dm = new DisplayTeamModel()
            {
                TeamName = item.Name,
                Players = players
                    .Select(p => new PlayerModel() {Name = p.FirstName + p.LastName}) //TODO move at mapper
                    .ToList(),
                PlayedAtChampionship = championShip.Select(p => new ChampionshipModel() {Name = p.Name}).ToList()
            };

            return dm;
        }

        public bool CheckTeamValid()
        {
            //Players.Count < _config.Count //TODO : exception or something else 
            throw new NotImplementedException();
        }
    }
}
