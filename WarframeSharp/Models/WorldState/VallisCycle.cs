using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class VallisCycle
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("isWarm")]
        public bool IsWarm { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }

        [JsonProperty("shortString")]
        public string ShortString { get; set; }
    }
}