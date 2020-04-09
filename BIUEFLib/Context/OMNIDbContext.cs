using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIUPocoLib;

namespace BIUEFLib.Context
{
    public class BIUDbContext : DbContext, IBIUDbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

        public BIUDbContext() : base("Name = BIUConnnection") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Maps.UserConfiguration());
            modelBuilder.Configurations.Add(new Maps.LoggingConfiguration());
            modelBuilder.Configurations.Add(new Maps.CityConfiguration());
            modelBuilder.Configurations.Add(new Maps.CountryConfiguration());
            modelBuilder.Configurations.Add(new Maps.AdressConfiguration());
        }
    }
}
