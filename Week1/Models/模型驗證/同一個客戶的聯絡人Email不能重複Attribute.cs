using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week1.Models.模型驗證
{
    public class 同一個客戶的聯絡人Email不能重複Attribute : ValidationAttribute
    {
        public 同一個客戶的聯絡人Email不能重複Attribute()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {

            }

            return base.IsValid(value, validationContext);
        }
    }
}