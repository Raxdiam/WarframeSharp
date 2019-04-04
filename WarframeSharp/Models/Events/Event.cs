using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Event
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

        [JsonProperty("maximumScore")]
        public long MaximumScore { get; set; }

        [JsonProperty("currentScore")]
        public long CurrentScore { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("concurrentNodes")]
        public List<object> ConcurrentNodes { get; set; }

        [JsonProperty("rewards")]
        public List<Reward> Rewards { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("interimSteps")]
        public List<object> InterimSteps { get; set; }

        [JsonProperty("progressSteps")]
        public List<object> ProgressSteps { get; set; }

        [JsonProperty("isPersonal")]
        public bool IsPersonal { get; set; }

        [JsonProperty("asString")]
        public string AsString { get; set; }
    }
}