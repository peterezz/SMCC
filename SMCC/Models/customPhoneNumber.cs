using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(customPhoneNumber))]
    public partial class StudentPhoneNumber
    {

    }
    public class customPhoneNumber
    {

        [Required(ErrorMessage = "ادخل رقم الموبايل")]
        [RegularExpression("[0]{1,1}[1]{1,1}[0-9]{9,9}", ErrorMessage = " ادخل رقم موبايل يبدأ بـ 01 و مكون من 11 رقم")]

        public string phoneNumber { get; set; }

        [RegularExpression("[0-9]{8,8}",ErrorMessage =" ادخل رقم هاتف مكون من 8 ارقام")]
        public string homeNumber { get; set; }

        [RegularExpression("[0]{1,1}[1]{1,1}[0-9]{9,9}", ErrorMessage = " ادخل رقم موبايل يبدأ بـ 01 و مكون من 11 رقم")]

        public string phonenumber2 { get; set; }

       
    }
}