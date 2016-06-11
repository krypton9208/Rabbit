using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using AspNet.Identity.MongoDB;

namespace Rabbit.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Rabb> Rabbits { get; set; }

        public User()
        {
            Rabbits = new HashSet<Rabb>();
        }
    }

    public class Role : IdentityRole
    {

    }


    //public class UserConfig : EntityTypeConfiguration<User>
    //{
    //    public UserConfig()
    //    {
    //        HasKey(x => x.Id);
    //        Property(x => x.FirstName).IsRequired().HasMaxLength(50).HasColumnName("FirstName");
    //        Property(x => x.LastName).IsRequired().HasMaxLength(50).HasColumnName("LastName");
    //        Property(x => x.Description).IsOptional().HasMaxLength(150).HasColumnName("Description");
    //    }
    //}
}
