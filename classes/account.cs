using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data.SqlClient;

using Newtonsoft.Json;


namespace ZappCash.classes
{
    //internal class account
    //{
    //}


    [Serializable]
    class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("attributes")]
        public AccountAttributes Attributes { get; set; }

        [JsonProperty("type")]
        public string AssetType { get; set; }
        
        
        [JsonProperty("placeholder")]
        public bool IsPlaceholder { get; set; }
        
        [JsonProperty("parent")]
        public string ParentId { get; set; }
        
        
        [JsonProperty("frac")]
        public byte Decimals { get; set; }
        
        
        [JsonProperty("bal")]
        public long Balance { get; set; }

        [JsonProperty("txns")]
        public List<Transaction> Transactions { get; set; }

        public Account(string id, AccountAttributes attributes, string assetType, bool isPlaceholder, string parentId, byte decimals)
        {
            Id = id;
            Attributes = attributes;
            AssetType = assetType;
            IsPlaceholder = isPlaceholder;
            ParentId = parentId;
            Decimals = decimals;
            Transactions = new List<Transaction>();
        }
    }

    public class AccountAttributes
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("col")]
        public string Color { get; set; }

        [JsonProperty("note")]
        public string Notes { get; set; }

        public AccountAttributes(string name, string code, string description, string color, string notes)
        {
            Name = name;
            Code = code;
            Description = description;
            Color = color;
            Notes = notes;
        }
    }
}
