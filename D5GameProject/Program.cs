using D5GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer { FirstName = "Volkan", LastName = "Torun", BirthYear = new DateTime(1990, 4, 7), NationalityId = "11223344556" };
            Gamer gamer2 = new Gamer { FirstName = "Emre", LastName = "Güneş", BirthYear = new DateTime(1996, 6, 24), NationalityId = "11223344556" };
            Gamer gamer3 = new Gamer { FirstName = "Fatma", LastName = "Bulut", BirthYear = new DateTime(1985, 1, 29), NationalityId = "11223344556" };
            gamerManager.Save(new Gamer { FirstName = "Enes", LastName = "Yılmaz", BirthYear = new DateTime(2015, 11, 2), NationalityId = "11223344556" });
            gamerManager.Save(gamer1);
            gamerManager.Save(gamer2);
            gamerManager.Save(gamer3);
            gamerManager.GetAll();
            gamerManager.Delete(gamer1);
            gamerManager.GetAll();

            GameManager gameManager = new GameManager();
            Game game1 = new Game { GameName = "Pes 2022", Price = 1000 };
            Game game2 = new Game { GameName = "FM 2022", Price = 750 };
            Game game3 = new Game { GameName = "NBA 2022", Price = 650 };
            gameManager.Save(game1);
            gameManager.Save(game2);
            gameManager.Save(game3);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { CampaignName = "Karne Kampanyası", CampaignDetail = "Karne Kampanyası", DiscountPercent = 50 };
            Campaign campaign2 = new Campaign { CampaignName = "Yaz Kampanyası", CampaignDetail = "Yaz Kampanyası", DiscountPercent = 20 };
            campaignManager.Save(campaign1);
            campaignManager.Save(campaign2);
            Console.WriteLine("-----------------------SATIŞLAR-----------------------");
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, game1);
            saleManager.SaleCampaign(gamer2, game2, campaign2);


        }
    }
}
