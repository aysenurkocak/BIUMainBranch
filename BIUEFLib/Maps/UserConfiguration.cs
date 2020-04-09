using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUEFLib.Maps
{
    public class UserConfiguration : EntityTypeConfiguration<BIUPocoLib.User>
    {

        public UserConfiguration () {
           
            ToTable("User", "BIU");
            HasKey(a => a.UserID);
            Property(a => a.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
        }
    }
}
