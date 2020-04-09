using BIUPocoLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BIUService
{
    public class AdressController
    {
        /// <summary>
        /// Adres ile alakalı CRUD 
        /// </summary>
        /// <param name="log"></param>
       public  void NewAdress(Adress Adr)
        {
            try
            {
                using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
                {
                    db.Adress.Add(Adr);
                    db.SaveChanges();
                }
             }
            catch(Exception ex)
            {
             
            }
        }
       public Adress GetAdress(int userId)
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var adress = (from a in db.Adress
                            where a.UserID == userId
                            select a).FirstOrDefault();
                return adress;
            }

        }
       public City GetCity(int cityId)
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var city = (from a in db.City
                              where a.Code == cityId
                              select a).FirstOrDefault();
                return city;
            }

        }
       public List<City> CityList()
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var list = (from a in db.City
                            select a).ToList();
                return list;
            }
        }
       public Country GetCountry(int countryId)
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var country= (from a in db.Country
                            where a.Code == countryId
                            select a).FirstOrDefault();
                return country;
            }

        }
       public List<Country> CountryList()
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var list = (from a in db.Country
                            select a).ToList();
                return list;
            }
        }
    }
}
