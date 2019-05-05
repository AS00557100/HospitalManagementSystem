using PatientBillingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientBillingSystem.Controllers
{
    public class UserController : Controller
    {
        #region Login page view

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region login and logout

        [HttpPost]
        public ActionResult Authorise(PatientBillingSystem.Models.usertbl loginModel)
        {
            using (dbPatientBillingEntities db = new dbPatientBillingEntities())
            {
                var userDetails = db.usertbls.Where(x => x.userName == loginModel.userName && x.userpassword == loginModel.userpassword).FirstOrDefault();
                if (userDetails == null)
                {
                    //loginModel.LoginErrormsg = "Wrong User Name or Password.";
                    ViewBag.Duplicatemsg = "Wrong Username and password";
                    return View("Index", loginModel);
                }
                else if(userDetails.userType == 1)
                {
                    Session["userType"] = userDetails.userType;
                    Session["userName"] = userDetails.userName;
                    return RedirectToAction("Admin", "User");
                }
                else if (userDetails.userType == 2)
                {
                    Session["userType"] = userDetails.userType;
                    Session["userName"] = userDetails.userName;
                    return RedirectToAction("Operator", "User");
                }
                else if (userDetails.userType == 3)
                {
                    Session["userType"] = userDetails.userType;
                    Session["userName"] = userDetails.userName;
                    return RedirectToAction("Doctor", "User");
                }
                else 
                {
                    Session["userType"] = userDetails.userType;
                    Session["userName"] = userDetails.userName;
                    return RedirectToAction("Patient", "User");
                }
            }
        }

        public ActionResult LogOut()
        {
            //int userId = (int)Session["userType"];
            string none = "none";
            Session.Abandon();
            Session["userType"] = none;
            Session["userName"] = none;
            return RedirectToAction("Index", "User");
        }
        #endregion`

        #region Admin

        public ActionResult Admin()
        {
            dbPatientBillingEntities4 db = new dbPatientBillingEntities4();
            var username = db.Admintbls.ToList();
            foreach (var item in username)
            {
                if (Session["userName"] != null)
                {
                    if (Session["userName"].Equals(item.A_userName))
                    {
                        ViewBag.user = (string)item.Admin_Name;
                        break;
                    }
                }
                else
                {
                    Response.Redirect("~/User/Index");
                }
            }
            return View();
        }

        #endregion

        #region Operator

        public ActionResult Operator()
        {
            dbPatientBillingEntities2 db = new dbPatientBillingEntities2();
            var username = db.Operatortbls.ToList();
            foreach (var item in username)
            {
                if (Session["userName"] != null)
                {
                    if (Session["userName"].Equals(item.O_userName))
                    {
                        ViewBag.user = (string)item.Operator_Name;
                        break;
                    }
                }
                else
                {
                    Response.Redirect("~/User/Index");
                }
            }
            return View();
        }

        #endregion

        #region Doctor

        public ActionResult Doctor()
        {
            dbPatientBillingEntities3 db = new dbPatientBillingEntities3();
            var username = db.Doctortbls.ToList();
            foreach (var item in username)
            {
                if (Session["userName"] != null)
                {
                    if (Session["userName"].Equals(item.D_userName))
                    {
                        ViewBag.user = (string)item.Doctor_Name;
                        break;
                    }
                }
                else
                {
                    Response.Redirect("~/User/Index");
                }
            }
            return View();
        }

        #endregion

        #region Patient

        public ActionResult Patient()
        {
            dbPatientBillingEntities1 db = new dbPatientBillingEntities1();
            var username = db.Patienttbls.ToList();
            foreach (var item in username)
            {
                if (Session["userName"] != null)
                {
                    if (Session["userName"].Equals(item.userName))
                    {
                        ViewBag.user = (string)item.Patient_Name;
                        break;
                    }
                }
                else
                {
                    Response.Redirect("~/User/Index");
                }
            }
            return View();
        }

        #endregion
    }
}