using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Models
{
    public class dbContext
    {
        private IMongoDatabase Database { get; set; }

        public dbContext()
        {
            var conn = "mongodb://localhost:27017";
            var client = new MongoClient(conn);
            Database = client.GetDatabase("Rabbit"); 
        }

        public IMongoDatabase GetDb
        {
            get
            {
                return Database;
            }
        }
        public IMongoCollection<Rabb> Rabbit => Database.GetCollection<Rabb>("rabbits");
    }

}
