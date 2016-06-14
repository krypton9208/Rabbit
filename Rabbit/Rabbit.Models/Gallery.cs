using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Rabbit.Models
{
    public class Gallery
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid GalleryId { get; set; }
        public string GalleryName { get; set; }
        public Guid RabbitId { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        public virtual Rabb Rabbit { get; set; }

        public Gallery()
        {
            Photos = new HashSet<Photo>();
        }
    }
}
