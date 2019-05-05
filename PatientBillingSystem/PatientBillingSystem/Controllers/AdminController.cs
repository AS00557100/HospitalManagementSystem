using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientBillingSystem.Models;

namespace PatientBillingSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PatientList()
        {
            dbPatientBillingEntities1 dbPatient = new dbPatientBillingEntities1();
            var patientTbl = dbPatient.Patienttbls.ToList();
            //ViewBag.patinetList = patientTbl;
            return View(patientTbl);
        }

        public ActionResult DoctorList()
        {
            dbPatientBillingEntities3 dbDoctor = new dbPatientBillingEntities3();
            var docTbl = dbDoctor.Doctortbls.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(docTbl);
        }

        public ActionResult OperatorList()
        {
            dbPatientBillingEntities2 dbOperator = new dbPatientBillingEntities2();
            var operatorTbl = dbOperator.Operatortbls.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(operatorTbl);
        }

        public ActionResult AdminList()
        {
            dbPatientBillingEntities4 dbAdmin = new dbPatientBillingEntities4();
            var adminTbl = dbAdmin.Admintbls.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(adminTbl);
        }

        public ActionResult ServicesList()
        {
            dbPatientBillingEntities5 dbServices = new dbPatientBillingEntities5();
            var servicesTbl = dbServices.servicesofferedtbls.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(servicesTbl);
        }

        //public ActionResult Edit(int id, Admintbl admodel)
        //{
        //    dbPatientBillingEntities4 dbAdmintbl = new dbPatientBillingEntities4();
        //    var dbAdminTblVals = dbAdmintbl.Admintbls.ToList();
        //    foreach (var item in dbAdminTblVals)
        //    {
        //        var valsToupdate = dbAdminTblVals.Where(e => e.Admin_ID == id).FirstOrDefault();
        //        if (valsToupdate != null)
        //        {
        //            valsToupdate.Gender = admodel.Gender;
        //            valsToupdate.A_address = admodel.A_address;
        //            valsToupdate.A_email = admodel.A_email;
        //            valsToupdate.PhoneNo = admodel.PhoneNo;
        //            dbAdmintbl.SaveChanges();
        //            //if (bedToupdate.bed_Availability == "YES")
        //            //{
        //            //    bedToupdate.bed_Availability = "NO";
        //            //    dbBedavail.SaveChanges();
        //            //}
        //            //else
        //            //{
        //            //    bedToupdate.bed_Availability = "YES";
        //            //    dbBedavail.SaveChanges();
        //            //}
        //        }
        //        break;
        //    }
        //    return RedirectToAction("AdminList");
        //}


    }
}