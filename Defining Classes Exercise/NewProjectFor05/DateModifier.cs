using System;
using System.Collections.Generic;
using System.Text;

namespace NewProjectFor05
{
    public static class DateModifier
    {
        public static double GetDaysBetween(string dateOne, string dateTwo)
        {
            DateTime dateTimeOne = DateTime.Parse(dateOne);
            DateTime dateTimeTwo = DateTime.Parse(dateTwo);

           double days = Math.Abs((dateTimeTwo - dateTimeOne).TotalDays);
           return days;
        }
    }
}
