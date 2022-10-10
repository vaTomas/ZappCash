using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ZappCash.classes
{
    class defaults
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        [JsonProperty("placeholder")]
        public bool IsPlaceholder { get; set; }

        [JsonProperty("decimals")]
        public byte Decimals { get; set; }

        [JsonProperty("accounts")]
        public List<_defaultAccount> Accounts { get; set; }
    }

    class _defaultAccount
    {
        [JsonProperty("name")]
        public string name { get; set; }
        
        [JsonProperty("parent")]
        public string parent { get; set; }
        
        [JsonProperty("placeholder")]
        public bool isPlaceholder { get; set; }

    }

}
