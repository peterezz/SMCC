using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMCC.Models
{
    public class singeltonClass
    {
        public List<StudentName> FullName = new List<StudentName>();
        private singeltonClass()
        {

        }
        private static singeltonClass instance = null;

        public static singeltonClass getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new singeltonClass();
                }
                return instance;
            }
        }
    }
}
    
