using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Week1.Models.輸入驗證
{
    public class CellPhoneAttribute : DataTypeAttribute
    {
        private static Regex _regex = new Regex(@"\d{4}-\d{6}", RegexOptions.IgnoreCase);

        public CellPhoneAttribute() : base(DataType.Text)
        {
            ErrorMessage = "手機號碼格式錯誤（e.g. 0911-111111）";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
	        {
		        return true;
	        }

            string valueAsString = value as string;
            return valueAsString != null && _regex.Match(valueAsString).Length > 0;
        }
    }
}