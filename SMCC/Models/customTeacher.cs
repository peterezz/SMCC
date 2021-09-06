using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(customTeacher))]
    public partial class Teacher
    {

    }
    public class customTeacher
    {
        [Required(ErrorMessage ="ادخل اسم المدرس")]
      
        public string TeacherName { get; set; }


        [Required(ErrorMessage ="ادخل رقم تليفون المدرس")]
        [RegularExpression("[0]{1,1}[1]{1,1}[0-9]{9,9}", ErrorMessage = " ادخل رقم موبايل يبدأ بـ 01 و مكون من 11 رقم")]
        public string teacherPhoneNumber { get; set; }
    }
}