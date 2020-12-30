using EventMenager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Repositories
{
    public interface IPlayerRepository
    {
        PlayerModel get(int playerId);
        IQueryable<PlayerModel> GetAll();
        void Add(PlayerModel player);
        void Delete(int playerId);
        void Update(int playerId, PlayerModel player);
    }
}
