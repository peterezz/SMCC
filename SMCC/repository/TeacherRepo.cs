using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMCC.Models;
using SMCC.Interface;
namespace SMCC.repository
{
    public class TeacherRepo : ITeacher
    {
        internal SMCC_SystemEntities3 db = new SMCC_SystemEntities3();
        public bool ADDTeacher(Teacher x)
        {
            var data = db.Teachers.Where(t => t.TeacherName == x.TeacherName && t.teacherPhoneNumber == x.teacherPhoneNumber).Count();
            if (data > 0)
            {
                return false;
            }
            else
            {
                db.Teachers.Add(x);
                db.SaveChanges();
                    return true;
            }
                

            


       }
    }
}