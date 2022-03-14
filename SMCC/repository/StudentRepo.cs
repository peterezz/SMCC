using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SMCC.Interface;
using SMCC.Models;

namespace SMCC.repository
{

    public class StudentRepo : IStudent
    {
        internal SMCCSystemEntities db = new SMCCSystemEntities();


        /// <summary>
        /// if no student is found, it saves the new name and returns its ID
        /// returns student name if student is found
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public StudentName getStudentbyName(StudentName x)
        {
            var StudentData = db.StudentNames.Where(model => model.FirstName == x.FirstName && model.SecondName == x.SecondName && model.ThirdName == x.ThirdName && model.FourthName == x.FourthName);
            if (StudentData.Count()!=0)
            {
                return StudentData.FirstOrDefault();
            }
            else
            {
                //x.Student.StudentID = x.StudentID;
                db.StudentNames.Add(x);
                db.SaveChanges();
                return x;
            }
        }





        public void AddStudent(StudentName x)
        {
            x.Student.StudentID = x.StudentID;
            x.StudentPhoneNumber.StudentID = x.StudentID;

            db.StudentPhoneNumbers.Add(x.StudentPhoneNumber);
            db.Students.Add(x.Student);
            db.SaveChanges();
        }


        public void UpdateStudent(StudentName x)
        {
            x.Student.StudentID = x.StudentID;
            x.StudentPhoneNumber.StudentID = x.StudentID;
            db.Entry(x.Student).State = EntityState.Modified;
            db.Entry(x.StudentPhoneNumber).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}