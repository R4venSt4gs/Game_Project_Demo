using System;

namespace Game_Project_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 01;
            user.National_Id = 12345678;
            user.First_Name = "ONUR";
            user.Last_Name = "GÜL";
            user.Date_Of_Birth = 1991;
            user.Username = "onurgul";

            Market_Place market_Place = new Market_Place();
            market_Place.Id = 001;
            market_Place.Game_Name = "GTA V";
            market_Place.Producer = "Rockstar Games";
            market_Place.Price = 100;
            market_Place.Discount = 10;
            market_Place.Seller = user.Username;

            Campaign campaign = new Campaign();
            campaign.Id = 0001;
            campaign.Campaign_Name = "İlk üyelere özel 10TL indirim.";
            campaign.Discount = 10;
            campaign.Exp_Date = 31 / 12 / 2021;

            //*********************************************************************
            
            User_Manager user_Manager = new User_Manager(new User_Valid_Manager());
            user_Manager.Add(user);
            user_Manager.Update(user);
            user_Manager.Delete(user);

            Console.WriteLine(" ");

            Market_Place_Manager market_Place_Manager = new Market_Place_Manager();
            market_Place_Manager.Add(market_Place);
            market_Place_Manager.Producer(market_Place);
            market_Place_Manager.Update(market_Place);
            market_Place_Manager.Price(market_Place);
            market_Place_Manager.Discount(market_Place);
            market_Place_Manager.Delete(market_Place);
            market_Place_Manager.Seller(market_Place);

            Console.WriteLine(" ");

            Campaign_Manager campaign1 = new Campaign_Manager();
            campaign1.Add(campaign);
            campaign1.Update(campaign);
            campaign1.Delete(campaign);

            Console.ReadLine();
        }
    }
}
