using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            CultureInfo ci = new CultureInfo("en-US");
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                ci,
                DateTimeStyles.None,
                out dateTime);
            //var isValid = DateTime.TryParseExact(Convert.ToString(value), "d MMM yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);

            return (isValid);
        }
    }

}