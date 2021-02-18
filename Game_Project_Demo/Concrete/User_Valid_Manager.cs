using Mernis_Service_Reference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Demo
{
    class User_Valid_Manager : IUser_Valid_Service
    {
        public bool Valid(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(user.National_Id, user.First_Name, user.Last_Name, user.Date_Of_Birth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
