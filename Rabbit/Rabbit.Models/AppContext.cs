using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Models
{
    public class AppContext : IdentityDbContext
    {
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Rabbit> Rabbit { get; set; }

        public AppContext()
            : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PhotoConfig());
            modelBuilder.Configurations.Add(new GalleryConfig());
            modelBuilder.Configurations.Add(new RabbitConf());
            modelBuilder.Configurations.Add(new UserConfig());
            base.OnModelCreating(modelBuilder);
        }

        public static AppContext Create()
        {
            return new AppContext();
        }
    }
}
