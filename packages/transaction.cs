using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZappCash.packages
{
    internal class transaction
    {
    }

    class Transaction
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public string numer { get; set; }
        public string description { get; set; }
        public string transferId { get; set; }
        public long amount { get; set; }
        public long balance { get; set; }
    }
}
