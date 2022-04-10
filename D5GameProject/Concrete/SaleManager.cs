using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+game.GameName+" oyununu "+ game.Price+"TL'ye satın aldı");
        }

        public void SaleCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            double gameprice =game.Price-(game.Price * campaign.DiscountPercent) / 100;
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " oyununu "+campaign.CampaignName+" ile %" +
                campaign.DiscountPercent + " indirimle " + gameprice + "TL'ye satın aldı");
        } 
    }
}
