using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientBillingSystem.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PatientsAlloted()
        {
            return View();
        }

        public ActionResult EditAvailability()
        {
            return View();
        }

        public ActionResult EditPatientStatus()
        {
            return View();
        }
    }
}