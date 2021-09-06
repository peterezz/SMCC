using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    [MetadataType(typeof(CustomLogin))]
    public partial class User
    {

    }
    public class CustomLogin
    {
        [Required(ErrorMessage ="ادخل الايميل")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ادخل رمز الدخول")]
        public string pass { get; set; }
    }
}