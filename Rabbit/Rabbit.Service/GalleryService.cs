using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rabbit.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Rabbit.Service
{
    public class GalleryService : IGalleryServicecs
    {
        private readonly IMongoCollection<Gallery> db;

        public IMongoCollection<Gallery> GetCollection => db;

        public GalleryService()
        {
            db = new dbContext().Gallery;
            //Add(new Gallery
            //{
            //    GalleryName = "nowa"
            //});
        }

        public void Add(Gallery t)
        {
            db.InsertOne(t);
        }

        public List<Gallery> GetAll()
        {
            return db.Find(new BsonDocument()).ToList();
        }

       
    }
}
