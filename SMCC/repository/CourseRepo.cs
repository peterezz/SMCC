using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMCC.Interface;
using SMCC.Models;

namespace SMCC.repository
{
    public class CourseRepo : ICourses
    {
        internal SMCC_SystemEntities3 db = new SMCC_SystemEntities3();

        public bool ADDCourse(Cours Course)
        {
            if (db.Courses.Where(model => model.CourseName == Course.CourseName).Count() > 0)
            {
                return false;
            }
            else
            {
                db.Courses.Add(Course);
                db.SaveChanges();
                return true;
            }
        }

        public bool Add_Student_To_Course(Student_Course x)
        {
            if(db.CourseAppointments.Find(x.CourseID) != null)
            {
            db.Student_Course.Add(x);
            db.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<CourseAppointment> getALLCoursesByDate(CourseAppointment a)
        {
            return db.CourseAppointments.Where(model => model.courseID == a.courseID && model.startDate >= a.startDate && model.endDate <= a.endDate).ToList();

        }

    
        public bool ScheduleCourse(CourseAppointment a)
        {
            db.CourseAppointments.Add(a);
            db.SaveChanges();
            return true;
        }
    }
}