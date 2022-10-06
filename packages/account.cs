using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data.SqlClient;


namespace ZappCash.packages
{
    internal class account
    {
    }


    [Serializable]
    class Account
    {
        public string id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public string notes { get; set; }
        public string type { get; set; }
        public bool placeholder { get; set; }
        public string parent { get; set; }
        public byte smallest_fraction { get; set; }
        public long balance { get; set; }
    }
}
