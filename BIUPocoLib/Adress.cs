using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUPocoLib
{

   public class Adress
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string District { get; set; }
        public string Detail { get; set; }
        public string PostCode { get; set; }
       

    }

    public class City
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    public class Country
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
   
}
