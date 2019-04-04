using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class SyndicateMission
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

        [JsonProperty("syndicate")]
        public string Syndicate { get; set; }

        [JsonProperty("nodes")]
        public List<string> Nodes { get; set; }

        [JsonProperty("jobs")]
        public List<Job> Jobs { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }
    }
}