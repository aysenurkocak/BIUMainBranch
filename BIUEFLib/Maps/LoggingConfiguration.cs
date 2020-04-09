using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUEFLib.Maps
{
    public class LoggingConfiguration : EntityTypeConfiguration<BIUPocoLib.Log>
    {

        public LoggingConfiguration() {
           
            ToTable("Logging", "BIU");
            HasKey(a => a.LogID);
            Property(a => a.LogID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
        }
    }
}
