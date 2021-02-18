using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    interface IUser_Service
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
