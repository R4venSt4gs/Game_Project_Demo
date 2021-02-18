using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    class Market_Place_Manager : IMarket_Place_Service
    {
        public void Add(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Game_Name + " isimli oyun satışa çıkartılmıştır.");
        }

        public void Delete(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Game_Name + " isimli oyun satıştan kaldırılmıştır.");
        }

        public void Discount(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Discount + " değerinde indirim bulunmaktadır.");
        }

        public void Price(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Price);
        }

        public void Producer(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Producer);
        }

        public void Seller(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Seller + " tarafından satılık.");
        }

        public void Update(Market_Place market_Place)
        {
            Console.WriteLine(market_Place.Game_Name + " isimli oyun bilgileri güncellenmiştir.");
        }
    }
}
