using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUEFLib.Maps
{
    public class CityConfiguration : EntityTypeConfiguration<BIUPocoLib.City>
    {
        
        public CityConfiguration() {
           
            ToTable("City", "BIU");
            HasKey(a => a.Code);
            Property(a => a.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
        }
    }
}
