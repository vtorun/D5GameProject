using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    class Sale : IEntity
    {
        public Sale()
        {
        }

        public Sale(int ıd, int gamerId, int gameId, double price)
        {
            Id = ıd;
            GamerId = gamerId;
            GameId = gameId;
            Price = price;
        }

        public Sale(int ıd, int gamerId, int gameId, int campaignId, double price)
        {
            Id = ıd;
            GamerId = gamerId;
            GameId = gameId;
            CampaignId = campaignId;
            Price = price;
        }

        public int Id { get; set; }
        public int GamerId { get; set; }
        public int GameId { get; set; }
        public int CampaignId { get; set; }
        public double Price { get; set; }
    }
}
