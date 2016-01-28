using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index(FormCollection data)
        {
            var firstname = data["fname_name"];
            var lastname = data["lname_name"];
            Response.Write("Full name is" + firstname + " " + lastname);
            return View();
        }
    }
}