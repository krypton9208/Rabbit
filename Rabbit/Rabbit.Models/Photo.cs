using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabbit.Models
{
    public class Photo
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid PhotoId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime PublishedTime { get; set; }
        public Guid GalleryId { get; set; }
        public virtual Gallery Gallery { get; set; }
    }

}