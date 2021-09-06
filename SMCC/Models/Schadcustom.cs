using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(Schadcustom))]
    public partial class CourseAppointment
    {

    }
    public class Schadcustom
    {
      

        [Required(ErrorMessage ="ادخل تاريخ بداية الكورس")]
        [DataType(DataType.Date)]
        public System.DateTime startDate { get; set; }


        [Required(ErrorMessage = "ادخل تاريخ نهاية الكورس")]
        [DataType(DataType.Date)]
        public System.DateTime endDate { get; set; }


        [Required(ErrorMessage = "اختر اليوم")]
        public string day1 { get; set; }


        
        public string day2 { get; set; }


        
        public string day3 { get; set; }

        [Required(ErrorMessage = "ادخل ميعاد بداية الكورس")]
        [DataType(DataType.Time)]
        public System.TimeSpan startTime { get; set; }


        [Required(ErrorMessage = "ادخل ميعاد نهاية الكورس")]
        [DataType(DataType.Time)]
        public System.TimeSpan endTime { get; set; }

        [Required(ErrorMessage = "ادخل السعر")]
        [DataType(DataType.Currency)]
        public int price { get; set; }

        [Required(ErrorMessage = "اختر اسم المدرس")]
        public Nullable<int> teacherID { get; set; }


        [Required(ErrorMessage = "اختر اسم القاعة")]
        public Nullable<int> classID { get; set; }


        [Required(ErrorMessage = "اختر اسم الكورس")]
        public Nullable<int> courseID { get; set; }

    }
}