using System;

using ZappCash.database;

namespace ZappCash.packages
{
    static class IdGenerator
    {
        public static string GenerateID(string parentID = null) //outputs non-random 16-char ID
        {
            if (parentID == null)
            {
                parentID = db_ZappCash.Defaults.AccountDefaults.ParentId;
            }

            DateTime dateToday = DateTime.Now;

            string year = dateToday.Year.ToString("X4");
            string day = dateToday.Day.ToString("X2");
            string month = dateToday.Month.ToString("X1");

            TimeSpan myspan = new TimeSpan(dateToday.Hour, dateToday.Minute, dateToday.Second);
            string seconds = ((int)myspan.TotalSeconds).ToString("X5");

            string random = Guid.NewGuid().ToString().ToUpper();
            random = random.Substring(random.Length - 6);
            string parent = parentID.Substring(parentID.Length - 6);


            string generatedID = $"{parent}{year}{month}{day}{seconds}{random}";
            generatedID = $"{generatedID.Substring(0, 8)}-{generatedID.Substring(8, 8)}-{generatedID.Substring(16, 8)}";
            return generatedID;
        }

    }
}
