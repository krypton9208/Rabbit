using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabbit.Models
{
    public class Gallery
    {
        public Guid GalleryId { get; set; }
        public string GalleryName { get; set; }
        public Guid RabbitId { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        public virtual Rabbit Rabbit { get; set; }

        public Gallery()
        {
            Photos = new HashSet<Photo>();
        }
    }
    public class GalleryConfig : EntityTypeConfiguration<Gallery>
    {
        public GalleryConfig()
        {
            HasKey(x => x.GalleryId);

            Property(x => x.GalleryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GalleryName).IsRequired().HasMaxLength(200).HasColumnName("Name");

            HasRequired(x => x.Rabbit).WithMany(x => x.Galleries).HasForeignKey(x => x.RabbitId);

            ToTable("Gallery");
        }
    }
}
