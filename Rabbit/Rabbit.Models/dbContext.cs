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
            var conn = "mongo://localhost";
            var client = new MongoClient(conn);
            Database = client.GetDatabase("Rabit"); 
        }

        public IMongoCollection<Rabbit> Rabbit => Database.GetCollection<Rabbit>("rabbits");
    }

}
