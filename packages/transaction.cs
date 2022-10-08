using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ZappCash.packages
{
    //internal class transaction
    //{
    //}

    class Transaction
    {

        //Variables
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("num")]
        public string Number { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("trans")]
        public string TransferId { get; set; }

        [JsonProperty("amnt")]
        public long Amount { get; set; }

        [JsonProperty("bal")]
        public long Balance { get; set; }


        //Initialization
        public Transaction(string Id, string Date = "", string Number = "", string Description = "", string TransferId = "", long Amount = 0, long Balance = 0)
        {
            this.Id = Id;
            this.Date = Date;
            this.Number = Number;
            this.Description = Description;
            this.TransferId = TransferId;
            this.Amount = Amount;
            this.Balance = Balance;
        }
    }
}
