using BIUPocoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BIUConsoleTest
{
    class Program
    {
       


        static void Main(string[] args)
        {
            //BIUService.UserController OPP = new BIUService.UserController();
            //OPP.NewUser(new User
            //{
            //    Name = "Cihat",
            //    LastName = "Gül",
            //    Email = "",
            //    IsEnabled = false,
            //    SendEmail = false,
            //    SendSMS = false,
            //    Tc = "32165379400",
            //    Password = "Ak3ofdojg",
            //    MobilePhone = "12345678911",
            //    CreatedDate = DateTime.Now,
            //    BirthDate = null,
            //    LastLoginDate = null,
            //});

            //var xx = OPP.UserList();

            BIUService.AdressController OPP = new BIUService.AdressController();
            //OPP.NewAdress(new Adress
            //{
            //   CityId=0,
            //   CountryId=0,
            //   UserID=1
            //});

         var x =   OPP.CityList();



        }
    }
}
