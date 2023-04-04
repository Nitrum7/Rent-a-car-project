namespace RentACar.Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class YearAfter1886ValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTimeValue = (DateTime)value;
            return dateTimeValue.Year > 1886;
        }
    }
}
