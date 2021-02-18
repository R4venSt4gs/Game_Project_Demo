using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    interface ICampaign_Service
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
