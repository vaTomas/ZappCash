using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZappCash.packages
{
    internal class IdGenerator
    {


        public string GenerateID(string parentID = "0000000000000000") //outputs non-random 3-char ID
        {

            string generatedID = "";

            DateTime dateToday = DateTime.Now;

            string year = dateToday.Year.ToString("X4");
            string day = dateToday.Day.ToString("X2");
            string month = dateToday.Month.ToString("X1");

            TimeSpan myspan = new TimeSpan(dateToday.Hour, dateToday.Minute, dateToday.Second);
            string second = ((int)(myspan.TotalSeconds)).ToString("X5");

            generatedID = $"{parentID.Substring(parentID.Length - 4)}{year}{month}{day}{second}";
            return generatedID;
        }

    }
}
