using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        List<Gamer> gamers = new List<Gamer>();
        public void Delete(Gamer gamer)
        {
            try
            {
                int id = Convert.ToInt32(gamer.Id);
                gamers.RemoveAt(id - 1);
            }
            catch (Exception)
            {

                Console.WriteLine("Silme İşlemi Başarısız!!!");
            }

        }

        public void GetAll()
        {
            Console.WriteLine("-----------Oyuncular-----------");
            foreach (Gamer gamer in gamers)
            {
                Console.WriteLine(+gamer.Id + " " + gamer.FirstName + " " + gamer.LastName);
            }
        }
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                gamer.Id = gamers.Count + 1;
                gamers.Add(gamer);
            }
            else
            {
                Console.WriteLine("Oyuncu Bulunamadı!!!");
            }

        }

        public void Update(Gamer gamer)
        {

        }
    }
}
