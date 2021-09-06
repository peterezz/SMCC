using SMCC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMCC.repository;
namespace SMCC.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo repo = new StudentRepo();
        // GET: Student


        [HttpPost]
        public ActionResult RegisterCourse(StudentName x)
        {

            TempData["FirstName"] = x.FirstName;
            TempData["SecondName"] = x.SecondName;
            TempData["ThirdName"] = x.ThirdName;
            TempData["FourthName"] = x.FourthName;

            return RedirectToAction("UpdateStudent");
        }

        [HttpGet]
        public ActionResult RegisterCourse(int? id)
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                return RedirectToAction("Courses", "Course");
            }
            TempData["CourseID"] = id;
            return View();
        }




        [HttpPost]
        public ActionResult UpdateStudent(StudentName x)
        {


            if (TempData.ContainsKey("studentID"))
            {
                x.StudentID = Convert.ToInt32(TempData["studentID"]);
                TempData["StudentID-2"] = x.StudentID;
                repo.UpdateStudent(x);
                return RedirectToAction("add_student", "Course");
            }
            else
            {
                return RedirectToAction("Courses", "Course");
            }
        }
        [HttpGet]
        public ActionResult UpdateStudent()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }

            if (TempData.ContainsKey("FirstName") && TempData.ContainsKey("SecondName") && TempData.ContainsKey("ThirdName") && TempData.ContainsKey("FourthName"))
            {
                StudentName x = new StudentName()
                {
                    FirstName = TempData["FirstName"].ToString(),
                    SecondName = TempData["SecondName"].ToString(),
                    ThirdName = TempData["ThirdName"].ToString(),
                    FourthName = TempData["FourthName"].ToString()

                };


                var StudentData = repo.getStudentbyName(x);
                TempData["studentID"] = StudentData.StudentID;
                if (repo.db.StudentPhoneNumbers.Find(StudentData.StudentID) == null && repo.db.Students.Find(StudentData.StudentID) == null)
                {
                    return RedirectToAction("AddStudentData");
                }
                return View(StudentData);
            }
            else
            {
                return RedirectToAction("Courses", "Course");

            }



        }
        
        
        
        [HttpPost]
        public ActionResult AddStudentData(StudentName x)
        {
            if (TempData.ContainsKey("studentID"))
            {
                x.StudentID = Convert.ToInt32(TempData["studentID"]);
                TempData["StudentID-2"] = x.StudentID;
                repo.AddStudent(x);
                return RedirectToAction("add_student", "Course");
            }
            else
            {
                return RedirectToAction("Courses", "Course");
            }


        }

        [HttpGet]
        public ActionResult AddStudentData()
        {
            if (Session["user"] == null)

            {
                return RedirectToAction("Login", "Home");
            }
            else
            if (TempData.ContainsKey("studentID"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Courses", "Course");

            }


        }
    }

       
}
