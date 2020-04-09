using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUPocoLib
{
    /// <summary>
    /// Bu class Db ye eklediğimiz Users tablosuna ait alanları içerir. 
    /// </summary>
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MembershipType  { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<DateTime> LastLoginDate  { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public string MobilePhone { get; set; }
        public bool SendEmail { get; set; }
        public bool SendSMS { get; set; }
        public string Tc { get; set; }
        public string Fax { get; set; }


    }
}
