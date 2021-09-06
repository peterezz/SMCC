using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMCC.repository;
using SMCC.Models;
using System.Web.Routing;

namespace SMCC.Controllers
{
    public class TeacherController : Controller
    {
        TeacherRepo repo = new TeacherRepo();
        // GET: Teacher
        [HttpPost]
        public ActionResult ADD_Teacher(Teacher x)
        {
            string[] fullName = x.TeacherName.Split(' ');
            if (fullName.Count()!=2)
            {
                ViewBag.Message = String.Format("اسم المدرس يجب ان يتكون من اسمين", DateTime.Now.ToString());
                return View();

            }
           else if (repo.ADDTeacher(x))
            {
                return RedirectToAction("SUCCESS", "Massege", new RouteValueDictionary(new { Controller = "Massege", Action = "SUCCESS", Id = 4 }));

            }
            else
            {

                ViewBag.Message = String.Format("هذا المدرس مسجل بالفعل", DateTime.Now.ToString());
                return View();
            }
        }



            [HttpGet]
        public ActionResult ADD_Teacher()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
    }
}