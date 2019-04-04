using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class ActiveChallenge
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

        [JsonProperty("isDaily", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsDaily { get; set; }

        [JsonProperty("isElite")]
        public bool IsElite { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("reputation")]
        public long Reputation { get; set; }
    }
}