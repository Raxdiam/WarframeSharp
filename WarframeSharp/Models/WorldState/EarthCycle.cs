using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class EarthCycle
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("isDay")]
        public bool IsDay { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }
    }
}