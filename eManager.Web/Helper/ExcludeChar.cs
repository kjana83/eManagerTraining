using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace eManager.Web.Helper
{
    public class ExcludeChar : ValidationAttribute
    {
        public string _chars;
        public ExcludeChar(string chars) : base ("{0} has invalid chars")
        {
            _chars = chars;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string inputString = value.ToString();
                if (inputString.Any(p => _chars.Contains(p)))
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
            }
            return ValidationResult.Success;
        }
    }
}