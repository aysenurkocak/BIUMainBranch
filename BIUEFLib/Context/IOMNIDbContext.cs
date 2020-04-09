using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIUPocoLib;
namespace BIUEFLib.Context
{
    public interface IBIUDbContext : IDisposable
    {
        DbSet<User> User { get; set; }
        DbSet<Log> Log{ get; set; }
        DbSet<Adress> Adress { get; set; }
        DbSet<City> City { get; set; }
        DbSet<Country> Country { get; set; }
    }

}
