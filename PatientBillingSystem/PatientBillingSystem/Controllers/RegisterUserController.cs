using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientBillingSystem.Models;

namespace PatientBillingSystem.Controllers
{
    public class RegisterUserController : Controller
    {

        #region User Registration
        // GET: RegisterUser
        [HttpGet]
        public ActionResult userRegistarer(int id = 0)
        {
            usertbl userRegModel = new usertbl();
            return View(userRegModel);
        }

        [HttpPost]
        public ActionResult userRegistarer(usertbl userRegModel)
        {
            using (dbPatientBillingEntities dbUserModel = new dbPatientBillingEntities())
            {
                if (dbUserModel.usertbls.Any(x => x.userName == userRegModel.userName))
                {
                    ViewBag.Duplicatemsg = "Username alredy exist.";
                    return View("userRegistarer", userRegModel);
                }
                dbUserModel.usertbls.Add(userRegModel);
                dbUserModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successfull.";
            return View("userRegistarer", new usertbl());
        }
        #endregion


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


        #region operator Registration

        [HttpGet]
        public ActionResult operatorRegister()
        {
            Operatortbl operRegModel = new Operatortbl();
            return View(operRegModel);
        }

        [HttpPost]
        public ActionResult operatorRegister(Operatortbl operRegModel)
        {
            dbPatientBillingEntities dbuserLogModel = new dbPatientBillingEntities();
            usertbl usertblvals = new usertbl();
            Operatortbl opertblvals = new Operatortbl();
            using (dbPatientBillingEntities2 dbPatientModel = new dbPatientBillingEntities2())
            {
                if (dbPatientModel.Operatortbls.Any(x => x.O_userName == operRegModel.O_userName))
                {
                    ViewBag.Duplicatemsg = "User already exist.";
                    return View("patientRegister", operRegModel);
                }
                else
                {
                    opertblvals.Operator_Name = operRegModel.Operator_Name;
                    opertblvals.Gender = operRegModel.Gender;
                    opertblvals.PhoneNo = operRegModel.PhoneNo;
                    opertblvals.PhoneNo = operRegModel.PhoneNo;
                    opertblvals.O_email = operRegModel.O_email;
                    opertblvals.O_address = operRegModel.O_address;
                    opertblvals.userType = operRegModel.userType;
                    usertblvals.userType = opertblvals.userType;
                    opertblvals.O_userName = operRegModel.O_userName;
                    usertblvals.userName = opertblvals.O_userName;
                    opertblvals.O_Password = operRegModel.O_Password;
                    usertblvals.userpassword = opertblvals.O_Password;

                }
                dbPatientModel.Operatortbls.Add(opertblvals);
                dbuserLogModel.usertbls.Add(usertblvals);
                dbuserLogModel.SaveChanges();
                dbPatientModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull.";
            return View("operatorRegister", new Operatortbl());

        }
        #endregion


        #region Doctor Registration

        [HttpGet]
        public ActionResult doctorRegister()
        {
            Doctortbl docRegModel = new Doctortbl();
            return View(docRegModel);
        }

        [HttpPost]
        public ActionResult doctorRegister(Doctortbl docRegModel)
        {
            dbPatientBillingEntities dbuserLogModel = new dbPatientBillingEntities();
            usertbl usertblvals = new usertbl();
            Doctortbl doctblvals = new Doctortbl();
            using (dbPatientBillingEntities3 dbDoctorModel = new dbPatientBillingEntities3())
            {
                if (dbDoctorModel.Doctortbls.Any(x => x.D_userName == docRegModel.D_userName))
                {
                    ViewBag.Duplicatemsg = "User already exist.";
                    return View("doctorRegister", docRegModel);
                }
                else
                {
                    doctblvals.Doctor_Name = docRegModel.Doctor_Name;
                    doctblvals.Gender = docRegModel.Gender;
                    doctblvals.PhoneNo = docRegModel.PhoneNo;
                    doctblvals.D_email = docRegModel.D_email;
                    doctblvals.specialization = docRegModel.specialization;
                    doctblvals.Consultation_Fee = docRegModel.Consultation_Fee;
                    doctblvals.userType = docRegModel.userType;
                    usertblvals.userType = doctblvals.userType;
                    doctblvals.D_userName = docRegModel.D_userName;
                    usertblvals.userName = doctblvals.D_userName;
                    doctblvals.D_Password = docRegModel.D_Password;
                    usertblvals.userpassword = doctblvals.D_Password;

                }
                dbDoctorModel.Doctortbls.Add(doctblvals);
                dbuserLogModel.usertbls.Add(usertblvals);
                dbuserLogModel.SaveChanges();
                dbDoctorModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull.";
            return View("doctorRegister", new Doctortbl());

        }
        #endregion


        #region Admin Registration

        [HttpGet]
        public ActionResult adminRegister()
        {
            dbPatientBillingEntities4 dbAdminModel = new dbPatientBillingEntities4();
            Admintbl adminRegModel = new Admintbl();
            var viewName = dbAdminModel.Admintbls.ToList();
            ViewBag.viewName = viewName;
            return View(adminRegModel);
        }

        [HttpPost]
        public ActionResult adminRegister(Admintbl adminRegModel)
        {
            dbPatientBillingEntities dbuserLogModel = new dbPatientBillingEntities();
            usertbl usertblvals = new usertbl();
            Admintbl admintblvals = new Admintbl();
            using (dbPatientBillingEntities4 dbAdminModel = new dbPatientBillingEntities4())
            {
                if (dbAdminModel.Admintbls.Any(x => x.A_userName == adminRegModel.A_userName))
                {
                    ViewBag.Duplicatemsg = "User already exist.";
                    return View("adminRegister", adminRegModel);
                }
                else
                {
                    admintblvals.Admin_Name = adminRegModel.Admin_Name;
                    admintblvals.Gender = adminRegModel.Gender;
                    admintblvals.PhoneNo = adminRegModel.PhoneNo;
                    admintblvals.A_email = adminRegModel.A_email;
                    admintblvals.A_address = adminRegModel.A_address;
                    admintblvals.userType = adminRegModel.userType;
                    usertblvals.userType = admintblvals.userType;
                    admintblvals.A_userName = adminRegModel.A_userName;
                    usertblvals.userName = admintblvals.A_userName;
                    admintblvals.A_Password = adminRegModel.A_Password;
                    usertblvals.userpassword = admintblvals.A_Password;

                }
                dbAdminModel.Admintbls.Add(admintblvals);
                dbuserLogModel.usertbls.Add(usertblvals);
                dbuserLogModel.SaveChanges();
                dbAdminModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull.";
            return View("adminRegister", new Admintbl());

        }

        #endregion


        #region Service registration

        [HttpGet]
        public ActionResult servicesRegister()
        {
            dbPatientBillingEntities5 dbServiceModel = new dbPatientBillingEntities5();
            servicesofferedtbl serviceRegModel = new servicesofferedtbl();
            var viewName = dbServiceModel.servicesofferedtbls.ToList();
            ViewBag.viewName = viewName;
            return View(serviceRegModel);
        }

        [HttpPost]
        public ActionResult servicesRegister(servicesofferedtbl serviceRegModel)
        {
            servicesofferedtbl servicetblvals = new servicesofferedtbl();
            using (dbPatientBillingEntities5 dbServiceModel = new dbPatientBillingEntities5())
            {
                if (dbServiceModel.servicesofferedtbls.Any(x => x.Service_Description == serviceRegModel.Service_Description))
                {
                    ViewBag.Duplicatemsg = "Service already exist.";
                    return View("servicesRegister", serviceRegModel);
                }
                else
                {
                    servicetblvals.Service_Description = serviceRegModel.Service_Description;
                    servicetblvals.Cost_Of_Service = serviceRegModel.Cost_Of_Service;
                }
                dbServiceModel.servicesofferedtbls.Add(servicetblvals);
                dbServiceModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Service Added Sucessfully.";
            return View("servicesRegister", serviceRegModel);

            #endregion
        }
    }
}