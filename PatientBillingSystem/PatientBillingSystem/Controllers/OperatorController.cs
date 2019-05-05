using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using PatientBillingSystem.Models;

namespace PatientBillingSystem.Controllers
{
    public class OperatorController : Controller
    {
        // GET: Operator
        public ActionResult Index()
        {
            return View();
        }

        #region patient Registration


        [HttpGet]
        public ActionResult patientRegister()
        {
            Patienttbl patientRegModel = new Patienttbl();
            return View(patientRegModel);
        }


        [HttpPost]
        public ActionResult patientRegister(Patienttbl patientRegModel)
        {
            dbPatientBillingEntities dbuserLogModel = new dbPatientBillingEntities();
            usertbl usertblvals = new usertbl();
            Patienttbl patienttblvals = new Patienttbl();
            using (dbPatientBillingEntities1 dbPatientModel = new dbPatientBillingEntities1())
            {
                if (dbPatientModel.Patienttbls.Any(x => x.userName == patientRegModel.userName))
                {
                    ViewBag.Duplicatemsg = "User already exist.";
                    return View("patientRegister", patientRegModel);
                }
                else
                {
                    patienttblvals.Patient_Name = patientRegModel.Patient_Name;
                    patienttblvals.Gender = patientRegModel.Gender;
                    patienttblvals.Age = patientRegModel.Age;
                    patienttblvals.Bloodgroup = patientRegModel.Bloodgroup;
                    patienttblvals.PhoneNo = patientRegModel.PhoneNo;
                    patienttblvals.P_email = patientRegModel.P_email;
                    patienttblvals.P_address = patientRegModel.P_address;
                    patienttblvals.P_Status = patientRegModel.P_Status;
                    patienttblvals.userType = patientRegModel.userType;
                    usertblvals.userType = patienttblvals.userType;
                    patienttblvals.userName = patientRegModel.userName;
                    usertblvals.userName = patienttblvals.userName;
                    patienttblvals.P_Password = patientRegModel.P_Password;
                    usertblvals.userpassword = patienttblvals.P_Password;

                }
                dbPatientModel.Patienttbls.Add(patienttblvals);
                dbuserLogModel.usertbls.Add(usertblvals);
                dbuserLogModel.SaveChanges();
                dbPatientModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull.";
            return View("patientRegister", new Patienttbl());
        }
        #endregion


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

        public ActionResult DoctorAvailability()
        {
            dbPatientBillingEntities7 dbDocAva = new dbPatientBillingEntities7();
            var docAvalTbl = dbDocAva.Doc_Available.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(docAvalTbl);
        }

        public ActionResult BedsAvailability()
        {
            dbPatientBillingEntities6 dbBeds = new dbPatientBillingEntities6();
            var bedTbl = dbBeds.Beds_Available.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(bedTbl);
        }

        public ActionResult BedAllocation()
        {
            dbPatientBillingEntities8 dbBedallo = new dbPatientBillingEntities8();
            var BedAllotTbl = dbBedallo.Bed_Allocation.ToList();
            //ViewBag.operatortList = OperatorTbl;
            return View(BedAllotTbl);
        }

        public ActionResult BillGeneration()
        {
            dbPatientBillingEntities5 ds = new dbPatientBillingEntities5();
            var items = ds.servicesofferedtbls.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            dbPatientBillingEntities6 dbBedavail = new dbPatientBillingEntities6();
            var dbBedTbl = dbBedavail.Beds_Available.ToList();
            foreach (var item in dbBedTbl)
            {
                var bedToupdate = dbBedTbl.Where(e => e.service_No == id).FirstOrDefault();
                if (bedToupdate != null)
                {
                    if (bedToupdate.bed_Availability == "YES")
                    {
                        bedToupdate.bed_Availability = "NO";
                        dbBedavail.SaveChanges();
                    }
                    else
                    {
                        bedToupdate.bed_Availability = "YES";
                        dbBedavail.SaveChanges();
                    }
                }
                break;
            }
            return RedirectToAction("BedsAvailability");
        }

        public ActionResult EditDoc(int id)
        {
            dbPatientBillingEntities7 dbDocavail = new dbPatientBillingEntities7();
            var dbDocTbl = dbDocavail.Doc_Available.ToList();
            foreach (var item in dbDocTbl)
            {
                var bedToupdate = dbDocTbl.Where(e => e.Doctor_No == id).FirstOrDefault();
                if (bedToupdate != null)
                {
                    if (bedToupdate.Doc_Availability== "YES")
                    {
                        bedToupdate.Doc_Availability = "NO";
                        dbDocavail.SaveChanges();
                    }
                    else
                    {
                        bedToupdate.Doc_Availability = "YES";
                        dbDocavail.SaveChanges();
                    }
                }
                break;
            }
            return RedirectToAction("DoctorAvailability");
        }

        [HttpGet]
        public ActionResult Allot()
        {
            dbPatientBillingEntities8 dbBedModel = new dbPatientBillingEntities8();
            Bed_Allocation bedallot = new Bed_Allocation();
            return View(bedallot);
        }


        [HttpPost]
        public ActionResult Allot(Bed_Allocation bedallot)
        {
            Bed_Allocation bedallotvals = new Bed_Allocation();
            using (dbPatientBillingEntities8 dbBedModel = new dbPatientBillingEntities8())
            {
                if (dbBedModel.Bed_Allocation.Any(x => x.Patient_ID == bedallot.Patient_ID))
                {
                    ViewBag.Duplicatemsg = "Patient already alloted.";
                    return View("Allot", bedallot);
                }
                else
                {
                    bedallotvals.Patient_ID = bedallot.Patient_ID;
                    bedallotvals.Patient_Name = bedallot.Patient_Name;
                    bedallotvals.Ward_Aolloted= bedallot.Ward_Aolloted;
                    bedallotvals.Bed_Aolloted = bedallot.Bed_Aolloted;
                }
                dbBedModel.Bed_Allocation.Add(bedallotvals);
                dbBedModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Bed Alloted";
            return View("Allot", new Bed_Allocation());
        }


        public ActionResult BillGenerate()
        {
            dbPatientBillingEntities5 ds = new dbPatientBillingEntities5();
            var items = ds.servicesofferedtbls.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }
            return View();
        }
    }
}