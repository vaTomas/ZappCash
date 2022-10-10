using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ZappCash.packages;
using ZappCash.classes;

namespace ZappCash.database
{
    class db_ZappCash
    {
        public static List<Account> Accounts { get; set; }
        public static fileRecord AccessFile { get; set; }
        public static fileRecord TempFile { get; set; }
        public static defaults Defaults { get; set; }


        public static void CheckIntegrity()
        {
            if (AccessFile == null) { AccessFile = new fileRecord(); }
            if (TempFile == null) { TempFile = new fileRecord(); }
            if (Accounts == null) { Accounts = new List<Account>(); }
            if (Defaults == null) { Accounts = new List<Account>(); }
        }
    }
}
