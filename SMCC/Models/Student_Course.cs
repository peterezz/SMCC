//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMCC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Course
    {
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<decimal> El_Ba2i { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string El_Twki3 { get; set; }
        public string Notes { get; set; }
        public int ID { get; set; }
        public Nullable<decimal> elMdfo3 { get; set; }
    
        public virtual CourseAppointment CourseAppointment { get; set; }
        public virtual StudentName StudentName { get; set; }
    }
}
