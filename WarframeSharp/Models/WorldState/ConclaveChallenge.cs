using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class ConclaveChallenge
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("daily")]
        public bool Daily { get; set; }

        [JsonProperty("rootChallenge")]
        public bool RootChallenge { get; set; }

        [JsonProperty("endString")]
        public string EndString { get; set; }

        [JsonProperty("asString")]
        public string AsString { get; set; }
    }
}