using AspNet.Identity.MongoDB;
using Microsoft.AspNet.Identity;
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
            var users = Database.GetCollection<User>("users");
            var store = new UserStore<User>(users);
            var manager = new UserManager<User>(store);

            // if you want roles too:
            var roles = Database.GetCollection<Role>("roles");
            var roleStore = new RoleStore<Role>(roles);

            IndexChecks.EnsureUniqueIndexOnUserName(users);
            IndexChecks.EnsureUniqueIndexOnEmail(users);

            IndexChecks.EnsureUniqueIndexOnRoleName(roles);
        }

        public IMongoDatabase GetDb
        {
            get
            {
                return Database;
            }
        }
        public IMongoCollection<Rabb> Rabbit => Database.GetCollection<Rabb>("rabbits");
        public IMongoCollection<Role> Roles => Database.GetCollection<Role>("roles");
        public IMongoCollection<User> Users => Database.GetCollection<User>("users");
        public IMongoCollection<Gallery> Gallery => Database.GetCollection<Gallery>("galeries");
        public IMongoCollection<Photo> Photos => Database.GetCollection<Photo>("photos");

    }

}
