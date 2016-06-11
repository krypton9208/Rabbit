using MongoDB.Driver;
using Rabbit.Models;
using Rabbit.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Rabbit.App.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {
        private RabbitService db = new RabbitService();

        [HttpGet]
        [Route("GetAllRabbit")]
        public async Task<List<Rabb>> GetAllRabbit()
        {
            return await db.GetAll();
        }
        [Route("GetRabbitByName/{name}")]
        [HttpGet]
        public IHttpActionResult GetRabbitByName(string name)
        {
            var rabb = db.GetByName(name);
            if (rabb == null)
            {
                return NotFound();
            }
            return Ok(rabb);
        }
    }
}
