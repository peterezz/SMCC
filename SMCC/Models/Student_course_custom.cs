using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(Student_course_custom))]
    public partial class Student_Course
    {

    }
    public class Student_course_custom
    {
     

        

     



        [Required(ErrorMessage ="لو مفيش باقى اكتب 0 فى الخانة")]
        [DataType(DataType.Currency)]
        public Nullable<int> El_Ba2i { get; set; }


        [Required(ErrorMessage ="ادخل المبلغ الذى دفعه الطالب")]
        [DataType(DataType.Currency)]
        public Nullable<int> elMdfo3 { get; set; }


        [Required(ErrorMessage ="ادخل تاريخ الدفع")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> PayDate { get; set; }




        [Required(ErrorMessage ="الامضاء")]
        public string El_Twki3 { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}