using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine(campaign.CampaignName + " isimli kampanya eklendi.");
            Console.WriteLine("-------------------");
        }

        public void Delete(Campaign campaign)
        {
            foreach (var item in campaigns)
            {
                if (item.CampaignName == campaign.CampaignName)
                {
                    campaigns.Remove(item);
                    Console.WriteLine(item.CampaignName + " isimli kampanya listeden çıkarıldı.");
                    Console.WriteLine("-------------------");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi.");
            Console.WriteLine("-------------------");
        }
    }
}
