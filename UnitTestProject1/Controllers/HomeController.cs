using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestProject1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string TestString = "Hello Lars !!!";

            ViewBag.Message = TestString;

            return View((object)TestString);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}