using Newtonsoft.Json;
using System;

namespace ZappCash.classes
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
        public DateTime Date { get; set; }

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
        public Transaction(string Id, string TransferId, DateTime Date, string Number = "", string Description = "", long Amount = 0, long Balance = 0)
        {
            this.Id = Id;
            this.Date = Date;
            this.Number = Number;
            this.Description = Description;
            this.TransferId = TransferId;
            this.Amount = Amount;
            this.Balance = Balance;
        }

        public Transaction() { }

    }
}
