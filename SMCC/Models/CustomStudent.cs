using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(CustomStudent))]
    public partial class Student
    {

    }
    public class CustomStudent
    {
        [Required(ErrorMessage ="ادخل العنوان")]
        [RegularExpression("[0-9]{1,3}-[a-zA-Z]{1,20}-[a-zA-Z]{1,10}-[a-zA-Z]{1,10}",ErrorMessage ="like: 12-eldsastr-Cairo-Egypt")]
        public string address { get; set; }



        [EmailAddress(ErrorMessage ="بريد الكترونى غير صحيح")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = " ادخل المؤهل او الوظيفة")]
        public string workInformation { get; set; }


        [Required(ErrorMessage = "ادخل الكنيسة التابع لها")]
        public string churchName { get; set; }
    }
}