using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZappCash.classes
{
    class zc_Defaults
    {
        [JsonProperty("account_defaults")]
        public zc_DefaultAccountSettings AccountDefaults { get; set; }
    }

    class zc_DefaultAccountSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("note")]
        public string Notes { get; set; }

        [JsonProperty("parent")]
        public string ParentId { get; set; }

        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        [JsonProperty("placeholder")]
        public bool IsPlaceholder { get; set; }

        [JsonProperty("decimals")]
        public byte Decimals { get; set; }

        [JsonProperty("accounts")]
        public List<zc_DefaultAccountsProperty> Accounts { get; set; }
    }

    class zc_DefaultAccountsProperty
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("parent")]
        public string parent { get; set; }

        [JsonProperty("placeholder")]
        public bool isPlaceholder { get; set; }

    }

}
