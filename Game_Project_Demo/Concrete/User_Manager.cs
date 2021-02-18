using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    class User_Manager : IUser_Service
    {
        IUser_Valid_Service _Valid_Service;

        public User_Manager(IUser_Valid_Service valid_Service)
        {
            _Valid_Service = valid_Service;
        }

        public void Add(User user)
        {
            if (_Valid_Service.Valid(user) == true)
            {
                Console.WriteLine(user.Username + " isimli hesabınız oluşturuldu.");
            }
            else
            {
                Console.WriteLine(user.Username + " hesap doğrulama başarısız.");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.Username + " isimli hesabınız silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.Username + " isimli hesap bilgileriniz güncellendi.");
        }
    }
}
