using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Moviecruiser.Utility
{
    public class DateUtility
    {
        public static DateTime ConvertToDate(string inputDate)
        {
            return DateTime.Parse(inputDate);
        }
    }
}
