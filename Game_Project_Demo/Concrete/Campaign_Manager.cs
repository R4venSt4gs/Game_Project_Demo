using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    class Campaign_Manager : ICampaign_Service
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Campaign_Name + " isimli kampanya sisteme eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Campaign_Name + " isimli kampanya sistemden silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Campaign_Name + " isimli kampanya güncellenmiştir.");
        }
    }
}
