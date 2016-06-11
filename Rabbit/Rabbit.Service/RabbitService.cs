using MongoDB.Bson;
using MongoDB.Driver;
using Rabbit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Service
{
    public class RabbitService : IRabbitService, IDisposable
    {
        private readonly IMongoCollection<Rabb> db;

        public IMongoCollection<Rabb> GetCollection => db;

        public RabbitService()
        {
            db = new dbContext().Rabbit;
            //Add(new Rabb
            //{
            //    Name = "Baksiu 1",
            //    Nicknames = "Baksinek biały",
            //    BirthDay = DateTime.Now
            //});
            //Add(new Rabb
            //{
            //    Name = "Baksiu 2",
            //    Nicknames = "Baksinek rudy",
            //    BirthDay = DateTime.Now
            //});
            //Add(new Rabb
            //{
            //    Name = "Baksiu 3",
            //    Nicknames = "Baksinek kolorowy",
            //    BirthDay = DateTime.Now
            //});
        }

        public async Task<List<Rabb>> GetAll()
        {
            return await db.Find(new BsonDocument()).ToListAsync();
        }



        public void Add(Rabb t)
        {
            db.InsertOne(t);
        }

        private string ReturnId(Rabb t)
        {
            return db.Find(x => x == t).FirstOrDefault().id;
        }

        public bool Delete(Rabb t)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Rabb GetByName(string t)
        {
            return db.Find(x => x.Name.ToLower().Contains(t.ToLower())).First();
        }
        public Rabb GetById(string t)
        {
            return db.Find(x => x.id == t).FirstOrDefault();
        }

        public bool Update(Rabb t)
        {
            throw new NotImplementedException();
        }
    }
}
