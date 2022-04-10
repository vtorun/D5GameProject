using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        public void Save(Campaign campaign);

        public void Update(Campaign campaign);

        public void Delete(Campaign campaign);
    }
}
