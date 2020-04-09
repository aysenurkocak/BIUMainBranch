using BIUPocoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BIUService
{
    public class UserController
    {
        public List<User> UserList()
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var list = (from a in db.User
                            select a).ToList();
                return list;
            }
        }

        public User GetUser(int userId)
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                var user = (from a in db.User
                            where a.UserID == userId
                            select a).FirstOrDefault();
                return user;
            }

        }

        public User Login(string email, string password)
        {
            using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
            {
                string Password = EncryptWithMD5(password);
                var user = (from a in db.User
                            where a.Password== Password && a.Email == email
                            select a).FirstOrDefault();
                return user;
            }
        }

        public void NewUser(User NUser)
        {
                using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
                {
                    NUser.Password = EncryptWithMD5(NUser.Password);
                    db.User.Add(NUser);
                    db.SaveChanges();
                }
        }

        /// <summary>
        /// Girilen parolayı md5 e çevrilir.
        /// ToString("x2") onaltılık tabanda hegzadesimal formata çevirmek için kullanılmıştır.
        /// Aralara - eklenmiştir.
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        private string EncryptWithMD5(string Password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Password));
            byte[] hash = md5.Hash;
            StringBuilder Pass = new StringBuilder();
            foreach (byte x in hash)
            {
                string Format = x.ToString("x2").ToUpper();
                Pass.Append(Format + "-");
            }
            return Pass.ToString().Substring(0, Pass.Length - 1);
        }

    }
}
