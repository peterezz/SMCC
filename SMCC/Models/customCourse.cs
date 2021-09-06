using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SMCC.Models
{
    [MetadataType(typeof(customCourse))]
    public partial class Cours
    {

    }
    public class customCourse
    {
        [Required(ErrorMessage ="ادخل اسم الكورس")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "ادخل عدد ساعات الكورس")]
        public int NumberOFhours { get; set; }
        [Required(ErrorMessage ="ادخل عدد محاضرات الكورس")]
        public int NumberOFlectures { get; set; }
     
    }
}