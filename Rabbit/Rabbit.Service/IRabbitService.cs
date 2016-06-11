using System;
using System.Collections.Generic;
using Rabbit.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Service
{
    public interface IRabbitService
    {
        Task<List<Rabb>> GetAll();
        void Add(Rabb t);
        bool Update(Rabb t);
        bool Delete(Rabb t);
        Rabb GetById(string t);
    }
}
