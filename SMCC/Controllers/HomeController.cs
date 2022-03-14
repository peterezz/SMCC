using SMCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCC.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        SMCCSystemEntities db = new SMCCSystemEntities();
        [HttpPost]
        public ActionResult Login(string email, string pass)
        {
            var data = db.Users.Where(model => model.Name == email && model.pass == pass).Count();
            if (email == "" || pass == "")
            {

                return RedirectToAction("Error", "Massege");

            }
            else if (data > 0)
            {
                Session["user"] = email;
                return RedirectToAction("AdminDashBoard");

            }
            else if (data == 0)
            {
                ViewBag.Message = String.Format("Wrong Email or Password", DateTime.Now.ToString());
                return View();
            }

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }


        public ActionResult AdminDashBoard()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        public ActionResult view()
        {
            return View();
        }
    }
}