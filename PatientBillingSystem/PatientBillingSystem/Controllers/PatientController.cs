using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientBillingSystem.Models;

namespace PatientBillingSystem.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PatientDetails()
        {
            dbPatientBillingEntities1 dbPatient = new dbPatientBillingEntities1();
            var username = dbPatient.Patienttbls.ToList();
            foreach (var item in username)
            {
                if (Session["userName"].Equals(item.userName))
                {
                    var patientTbl = dbPatient.Patienttbls.ToList();
                }
                break;
            }
            return View();
        }

        public ActionResult ViewServices()
        {
            dbPatientBillingEntities5 dbService = new dbPatientBillingEntities5();
            var serviceTbl = dbService.servicesofferedtbls.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(serviceTbl);
        }

        public ActionResult ViewBill()
        {
            return View();
        }
    }
}