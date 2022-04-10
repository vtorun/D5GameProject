using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IGamerService
    {
        public void Save(Gamer gamer);

        public void Update(Gamer gamer);

        public void Delete(Gamer gamer);
        public void GetAll();
    }
}
