using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data.SqlClient;


namespace ZappCash.packages
{
    //internal class account
    //{
    //}


    [Serializable]
    class Account
    {
        public string id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public string notes { get; set; }
        public string assetType { get; set; }
        public bool placeholder { get; set; }
        public string parentId { get; set; }
        public byte decimals { get; set; }
        public long balance { get; set; }
        public Transaction[] transactions { get; set; }
    }
}
