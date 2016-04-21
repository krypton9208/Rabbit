using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Models
{
    public class Rabbit
    {
        public Guid RabbitId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        
        public virtual ICollection<Gallery> Galleries { get; set; }

        public Rabbit()
        {
            Galleries = new HashSet<Gallery>();
        }
    }
}
