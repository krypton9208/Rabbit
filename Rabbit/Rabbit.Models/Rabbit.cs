using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Models
{
    public class Rabbit
    {
        public Guid RabbitId { get; set; }
        public string Name { get; set; }
        public string Nicknames { get; set; }
        public DateTime BirthDay { get; set; }
        public string Breed { get; set; }
        public string AboutRabbit { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }

        public string UserId { get; set; }
        public virtual User User {get;set;}

        public Rabbit()
        {
            Galleries = new HashSet<Gallery>();
        }
    }

    //public class RabbitConf : EntityTypeConfiguration<Rabbit>
    //{
    //    public RabbitConf()
    //    {
    //        HasKey(x => x.RabbitId);

    //        Property(x => x.RabbitId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnName("Name");
    //        Property(x => x.Nicknames).IsOptional().HasMaxLength(250).HasColumnName("Nicknames");
    //        Property(x => x.BirthDay).IsRequired().HasColumnType("datetime2");
    //        Property(x => x.Breed).IsOptional().HasMaxLength(50).HasColumnName("Breed");
    //        Property(x => x.AboutRabbit).IsRequired().HasMaxLength(500).HasColumnName("Description");

    //        HasRequired(x => x.User).WithMany(x => x.Rabbits).HasForeignKey(x=>x.UserId);

    //        ToTable("Rabbit");

    //    }
    //}
}
