using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMCC.Models;

namespace SMCC.Interface
{
    interface ICourses
    {
        bool ADDCourse(Cours Course);
        bool ScheduleCourse(CourseAppointment a);
        IEnumerable<CourseAppointment> getALLCoursesByDate(CourseAppointment a);
        bool Add_Student_To_Course(Student_Course x);
    }
}
