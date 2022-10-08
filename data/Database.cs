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
    }
}
