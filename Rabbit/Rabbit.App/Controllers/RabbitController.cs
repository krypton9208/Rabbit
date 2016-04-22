using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rabbit.App
{
    [Authorize]
    public class RabbitController : Controller
    {

        // GET: Rabbit
        public ActionResult Index()
        {
            return View();
        }
    }
}