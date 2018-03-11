using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada
{
    public class MinhaValidacaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (((string)value).Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
