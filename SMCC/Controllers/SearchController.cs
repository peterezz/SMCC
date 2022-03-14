using SMCC.Models;
using SMCC.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SMCC.Controllers
{
    public class SearchController : Controller
    {
        SMCCSystemEntities db = new SMCCSystemEntities();
        CourseRepo repo = new CourseRepo();
       
       
     // GET: Search

    



        [HttpPost]
        public ActionResult SearchCourse(CourseAppointment a)
        {
            if(a.startDate>a.endDate)
            {
                ViewBag.Message = String.Format("تأكد من ادخال التاريخ بطريقة صحيحة", DateTime.Now.ToString());
                return View();
            }
            else
            {
                var course = repo.getALLCoursesByDate(a);
                    return View(course);
        }
            }
   

        }
}