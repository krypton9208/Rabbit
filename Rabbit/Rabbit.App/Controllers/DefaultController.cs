using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rabbit.Service;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Rabbit.Models;

namespace Rabbit.App.Controllers
{
    public class DefaultController : Controller
    {
        
     

        public ActionResult Index()
        {
            return View();
        }
    }
}