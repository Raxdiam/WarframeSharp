using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class DailyDeal
    {
        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("originalPrice")]
        public long OriginalPrice { get; set; }

        [JsonProperty("salePrice")]
        public long SalePrice { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("sold")]
        public long Sold { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("discount")]
        public long Discount { get; set; }
    }
}