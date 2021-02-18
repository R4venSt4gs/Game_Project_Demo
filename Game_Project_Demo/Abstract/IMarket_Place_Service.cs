using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    interface IMarket_Place_Service
    {
        void Add(Market_Place market_Place);
        void Update(Market_Place market_Place);
        void Delete(Market_Place market_Place);
        void Discount(Market_Place market_Place);
        void Price(Market_Place market_Place);
        void Seller(Market_Place market_Place);
        void Producer(Market_Place market_Place);
    }
}
