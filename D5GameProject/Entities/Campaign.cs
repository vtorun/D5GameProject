using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Campaign : IEntity
    {
        public Campaign()
        {
        }

        public Campaign(string campaignName, double discountPercent, string campaignDetail)
        {
            CampaignName = campaignName;
            DiscountPercent = discountPercent;
            CampaignDetail = campaignDetail;
        }

        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double DiscountPercent { get; set; }
        public string CampaignDetail { get; set; }

    }
}
