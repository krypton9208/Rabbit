using MongoDB.Driver;
using Rabbit.Models;
using Rabbit.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rabbit.App.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        private RabbitService db = new RabbitService();

        [HttpGet]
        [Route("GetAllRabbit")]
        public IEnumerable<Rabb> GetAllRabbit()
        {
            return db.GetAll;
        }
        [Route("GetRabbitByName/{name:string}")]
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
