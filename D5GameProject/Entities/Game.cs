using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Game : IEntity
    {
        public Game()
        {
        }

        public Game(string gameName, double price)
        {
            GameName = gameName;
            Price = price;
        }

        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}
