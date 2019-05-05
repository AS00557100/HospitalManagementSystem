using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientBillingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "DR Fred Hospitals Services";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "DR Fred Hospitals Services";

            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "DR Fred Hospitals Services";

            return View();
        }
    }
}