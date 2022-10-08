using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZappCash.packages
{
    static class IdGenerator
    {
        public static string GenerateID(string parentID = "0000000000000000") //outputs non-random 16-char ID
        {

            DateTime dateToday = DateTime.Now;

            string year = dateToday.Year.ToString("X4");
            string day = dateToday.Day.ToString("X2");
            string month = dateToday.Month.ToString("X1");

            TimeSpan myspan = new TimeSpan(dateToday.Hour, dateToday.Minute, dateToday.Second, dateToday.Millisecond);
            string second = ((int)(myspan.TotalMilliseconds)).ToString("X7");


            string generatedID = $"{parentID.Substring(parentID.Length - 2)}{year}{month}{day}{second}";
            return generatedID;
        }

    }
}
