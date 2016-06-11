﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Rabbit.SPA.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
