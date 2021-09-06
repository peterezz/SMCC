using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCC.Controllers
{
    public class MassegeController : Controller
    {
        // GET: Massege
        [HttpGet]
        public ActionResult SUCCESS(int? id)
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.actionName = "";
            ViewBag.controllerName = "";
            if (id == 1)
            {
                ViewBag.controllerName = "Course";
                ViewBag.actionName = "ADD_Course";
            }
            else if (id == 2)
            {
                ViewBag.controllerName = "Course";
                ViewBag.actionName = "ScheduleCourse";
            }
            else if (id == 3)
            {
                ViewBag.controllerName = "Course";
                ViewBag.actionName = "Courses";
            }
            else if (id == 4)
            {
                ViewBag.controllerName = "Teacher";
                ViewBag.actionName = "ADD_Teacher";
            }
            else if (id == null)
            {
                return HttpNotFound();
            }
            return View();
        }
        public ActionResult Failed()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}