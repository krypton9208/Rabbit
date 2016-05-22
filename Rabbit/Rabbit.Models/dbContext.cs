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
        private MongoDatabase database { get; set; }

        public dbContext()
        {
            var conn = "mongo://localhost";
            var client = new MongoClient(conn);
#pragma warning disable CS0618 // Type or member is obsolete
            var server = client.GetServer();
#pragma warning restore CS0618 // Type or member is obsolete
            database = server.GetDatabase("Rabbit");
        }

        public MongoDatabase db
        {
            get
            {
                return database;
            }
        }
    }

}
