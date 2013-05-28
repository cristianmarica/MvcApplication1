using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to 1!";
            ViewData["Message2"] = "Modified to add changes on 2";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
