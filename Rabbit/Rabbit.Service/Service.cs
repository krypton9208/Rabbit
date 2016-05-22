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
    public class Service<T> : IService<T>, IDisposable
    {
        private readonly MongoDatabase db;

        public IEnumerable<T> GetAll
        {
            get
            {
                return db.GetCollection<T>("ddas").FindAll().ToBsonDocument().ToListAsync().Result;
            }
        }

        public Service()
        {
            db = new dbContext().db;
        }

        public int Add(T t)
        {
            throw new NotImplementedException();
        }

        public bool Update(T t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T GetById(int t)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
