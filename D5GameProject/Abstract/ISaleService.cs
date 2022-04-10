using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void SaleCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
