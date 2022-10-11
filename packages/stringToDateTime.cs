using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZappCash.packages
{
    static class zc_dateTime
    {
        public static DateTime stringToDateTime(string Date) // MM/dd/yyyy
        {
            DateTime date = DateTime.ParseExact(Date, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            return date;
        }

        public static string dateTimeToString(DateTime Date)
        {
            return Date.ToString("MM/dd/yyyy");
        }

        public static string stringNow()
        {
            return dateTimeToString(DateTime.Now);
        }
    }
}
