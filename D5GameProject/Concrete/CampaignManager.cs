using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Save(Campaign campaign)
        {
            campaigns.Add(campaign);
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
