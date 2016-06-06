using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabbit.Models
{
    public class Photo
    {
        public Guid PhotoId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime PublishedTime { get; set; }

        public Guid GalleryId { get; set; }
        public virtual Gallery Gallery { get; set; }
    }

    //public class PhotoConfig : EntityTypeConfiguration<Photo>
    //{
    //    public PhotoConfig()
    //    {
    //        HasKey(x => x.PhotoId);

    //        Property(x => x.PhotoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(x => x.FileName).IsRequired().HasMaxLength(250).HasColumnName("FirstName");
    //        Property(x => x.Description).IsOptional().HasMaxLength(250).HasColumnName("Description");
    //        Property(x => x.PublishedTime).IsRequired().HasColumnType("datetime2");
    //        HasRequired(x => x.Gallery).WithMany(x => x.Photos).HasForeignKey(x => x.GalleryId);
    //        ToTable("Photo");
    //    }
    //}
}