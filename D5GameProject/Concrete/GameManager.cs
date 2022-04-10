using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void Save(Game game)
        {
            games.Add(game);
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
