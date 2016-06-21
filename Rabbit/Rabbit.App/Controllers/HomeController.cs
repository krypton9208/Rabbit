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
using System.Web.Http.Description;

namespace Rabbit.App.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {
        private RabbitService db_Rabb = new RabbitService();
        private GalleryService db_Gall = new GalleryService();

        [HttpGet]
        [Route("GetAllRabbit")]
        public async Task<List<Rabb>> GetAllRabbit()
        {
            return await db_Rabb.GetAll();
        }

        [Route("GetRabbitByName/{name}")]
        [HttpGet]
        public IHttpActionResult GetRabbitByName(string name)
        {
            var rabb = db_Rabb.GetByName(name);
            if (rabb == null)
            {
                return NotFound();
            }
            return Ok(rabb);
        }

        [HttpGet]
        [Route("GetAllGalleries")]
        public Gallery[] GetAllGalleries()
        {
            return db_Gall.GetAll().ToArray();
        }
        public class INewPost
        {
            public string name { get; set; }
        }
        [HttpPost]
        [Route("SaveNewGallery")]
        [ResponseType(typeof(INewPost))]
        public IHttpActionResult SaveNewGallery(HttpRequestMessage request,[FromBody] INewPost post)
        {
            if (post.name.Length > 0) db_Gall.Add(new Gallery
            {
                GalleryName = post.name
            });
            return Ok();
        }
    }
}
