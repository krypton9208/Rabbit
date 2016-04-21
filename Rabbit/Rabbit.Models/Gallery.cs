using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Models
{
    public class Gallery
    {
        public string GalleryName { get; set; }
        public Guid RabbitId { get; set; }

        public virtual ICollection<string> Photos { get; set; }

        public virtual Rabbit Rabbit { get; set; }

        public Gallery()
        {
            Photos = new HashSet<string>();
        }
    }
}
