using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class FlashSale
    {
        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("discount")]
        public long Discount { get; set; }

        [JsonProperty("regularOverride")]
        public long RegularOverride { get; set; }

        [JsonProperty("premiumOverride")]
        public long PremiumOverride { get; set; }

        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; set; }

        [JsonProperty("isPopular")]
        public bool IsPopular { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }
    }
}