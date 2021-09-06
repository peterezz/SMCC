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
    public class CourseController : Controller
    {
        CourseRepo repo = new CourseRepo();

        // GET: Course



        [HttpPost]
        public ActionResult ADD_Course(Cours c)
        {
            if (ModelState.IsValid)
            {
                if (repo.ADDCourse(c))
                {
                    return RedirectToAction("SUCCESS", "Massege", new RouteValueDictionary(new { Controller = "Massege", Action = "SUCCESS", Id = 1 }));

                }
                else
                {

                    ViewBag.Message = String.Format("هذا الكورس مسجل بالفعل", DateTime.Now.ToString());
                    return View();
                }
                
            }
         
                return View();
            
        }
        [HttpGet]
        public ActionResult ADD_Course()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }



        [HttpPost]
        public ActionResult ScheduleCourse(CourseAppointment a)
        {
             ViewBag.courseName = new SelectList(repo.db.Courses, "CourseID", "CourseName");
            ViewBag.className = new SelectList(repo.db.Classes, "ClassID", "ClassName");
            ViewBag.TeacherName = new SelectList(repo.db.Teachers, "TeacherID", "TeacherName");


            var lista = new List<string>() { "SAT", "SUN", "MON", "TUE", "WED", "THU", "FRI" };
            ViewBag.selectDay = lista;
            if (a.startDate > a.endDate)
            {
                ViewBag.Message = String.Format("عدد ايام الكورس غير مناسبة", DateTime.Now.ToString());
                return View();
            }
            else if (a.startTime > a.endTime)
            {
                ViewBag.Message = String.Format("عدد ساعات الكورس غير مناسبة", DateTime.Now.ToString());
                return View();


            }
            else if (ModelState.IsValid)
            {
               if(repo.ScheduleCourse(a))
                {
                return RedirectToAction("SUCCESS", "Massege", new RouteValueDictionary(new { Controller = "Massege", Action = "SUCCESS", Id = 2 }));
                }

            }
       
                return View();
            
        }
        [HttpGet]
        public ActionResult ScheduleCourse()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.courseName = new SelectList(repo.db.Courses, "CourseID", "CourseName");
            ViewBag.className = new SelectList(repo.db.Classes, "ClassID", "ClassName");
            ViewBag.TeacherName = new SelectList(repo.db.Teachers, "TeacherID", "TeacherName");
            var lista = new List<string>() { "SAT", "SUN", "MON", "TUE", "WED", "THU", "FRI" };
            ViewBag.selectDay = lista;



            return View();
        }



        [HttpPost]
        public ActionResult add_student(Student_Course student_Course)
        {
            if(student_Course.elMdfo3<student_Course.El_Ba2i)
            {
                ViewBag.Message = String.Format("تأكد من البيانات لأن المبلغ المتبقى اكبر من المبلغ المدفوع", DateTime.Now.ToString());
                return View();

            }
            else if (TempData.ContainsKey("StudentID-2") && TempData.ContainsKey("CourseID"))
                {
                 student_Course.StudentID = Convert.ToInt32( TempData["StudentID-2"]);
                student_Course.CourseID = Convert.ToInt32(TempData["CourseID"]);
              
                if (repo.Add_Student_To_Course(student_Course))
                {
                    return RedirectToAction("SUCCESS", "Massege", new RouteValueDictionary(new { Controller = "Massege", Action = "SUCCESS", Id = 3 }));

                }
                else
                {
                    return RedirectToAction("ScheduleCourse");

                }




            }

            return RedirectToAction("Courses");




        }
        [HttpGet]
        public ActionResult add_student()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            if (TempData.ContainsKey("studentID"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Courses", "Course");

            }

        
        }



        [HttpGet]
        public ActionResult Courses()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.CourseName=new SelectList(repo.db.Courses,"CourseID", "CourseName");
            return View();
        }
    }
}