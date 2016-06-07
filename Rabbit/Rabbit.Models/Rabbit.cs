using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Models
{
    public class Rabb
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string Name { get; set; }
        public string Nicknames { get; set; }
        public DateTime BirthDay { get; set; }
        public string Breed { get; set; }
        public string AboutRabbit { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public Rabb()
        {
            Galleries = new HashSet<Gallery>();
        }
    }


}
