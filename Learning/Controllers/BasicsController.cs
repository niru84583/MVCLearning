using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class BasicsController : Controller
    {
        // GET: Basics
        public ActionResult Index()
        {
            @ViewBag.message = "Welcome to Get and Post";
            return View();
        }
    }
}