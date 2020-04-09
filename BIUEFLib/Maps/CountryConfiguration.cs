using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUEFLib.Maps
{
    public class CountryConfiguration : EntityTypeConfiguration<BIUPocoLib.Country>
    {
        
        public CountryConfiguration() {
           
            ToTable("Country", "BIU");
            HasKey(a => a.Code);
            Property(a => a.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
        }
    }
}
