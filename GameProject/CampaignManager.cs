using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : CampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Tutarınıza %" + campaign.discountRate + " oranında indirim uygulanacaktır. ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Tutarınıza uygulanan indirim silinmiştir. " );
        }
    }
}
