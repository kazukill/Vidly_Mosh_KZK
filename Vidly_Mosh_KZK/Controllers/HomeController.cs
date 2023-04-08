using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly_Mosh_KZK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}