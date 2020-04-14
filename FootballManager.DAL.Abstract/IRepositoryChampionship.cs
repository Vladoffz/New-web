using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryChampionship : ISyncRepository<int, Championship>
    {
        List<Championship> GetForCommand(in int itemCommandId);
    }
}


