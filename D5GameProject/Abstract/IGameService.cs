using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IGameService
    {
        public void Save(Game game);

        public void Update(Game game);

        public void Delete(Game game);
    }
}
