using SMCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCC.Interface
{
    interface IStudent
    {
        StudentName getStudentbyName(StudentName x);
        void AddStudent(StudentName x);
        void UpdateStudent(StudentName x);
   
    }
}

