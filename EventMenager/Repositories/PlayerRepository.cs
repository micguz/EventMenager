using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMenager.Models;

namespace EventMenager.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {

        private readonly EventMenagerContext _context;

        public PlayerRepository(EventMenagerContext context)
        {
            _context = context;
        }

        public void Add(PlayerModel player)
        {
            _context.Add(player);
            _context.SaveChanges();
        }

        public PlayerModel get(int playerId)
        => _context.Players.FirstOrDefault(s=>s.PlayerId==playerId);


        public IQueryable<PlayerModel> GetAll()
        => _context.Players.Where(s=>s.PlayerId!=null);

        public void Delete(int playerId)
        {
            var result = _context.Players.FirstOrDefault(s => s.PlayerId == playerId);
            if (result != null)
            {
                _context.Players.Remove(result);
                _context.SaveChanges();
            }
        }

        public void Update(int playerId, PlayerModel player)
        {
            var result = _context.Players.FirstOrDefault(s => s.PlayerId == playerId);
            if(result!=null)
            {
                result.Name = player.Name;
                result.Surname = player.Surname;
                result.DateOfBirdth = player.DateOfBirdth;
                result.Gender = player.Gender;
                _context.SaveChanges();

            }
        }
    }
}
