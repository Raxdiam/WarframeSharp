using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Fissure
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTimeOffset Activation { get; set; }

        [JsonProperty("startString")]
        public string StartString { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("missionType")]
        public string MissionType { get; set; }

        [JsonProperty("enemy")]
        public Enemy Enemy { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("tierNum")]
        public long TierNum { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }
    }
}