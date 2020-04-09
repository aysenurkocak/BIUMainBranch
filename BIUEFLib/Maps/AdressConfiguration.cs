using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUEFLib.Maps
{
    public class AdressConfiguration : EntityTypeConfiguration<BIUPocoLib.Adress>
    {
        
        public AdressConfiguration () {
           
            ToTable("Adress", "BIU");
            HasKey(a => a.Id);
            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
        }
    }
}
