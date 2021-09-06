using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(cutomStudentName))]
    public partial class StudentName
    {

    }
    public class cutomStudentName
    {
        [Required(ErrorMessage ="ادخل الاسم الاول")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "ادخل الاسم الثانى")]
        public string SecondName { get; set; }


        [Required(ErrorMessage = "ادخل الاسم الثالث")]
        public string ThirdName { get; set; }


        [Required(ErrorMessage = "ادخل الاسم الرابع")]
        public string FourthName { get; set; }

    }
}