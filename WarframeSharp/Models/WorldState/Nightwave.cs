using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Nightwave
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

        [JsonProperty("season")]
        public long Season { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("phase")]
        public long Phase { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }

        [JsonProperty("possibleChallenges")]
        public List<object> PossibleChallenges { get; set; }

        [JsonProperty("activeChallenges")]
        public List<ActiveChallenge> ActiveChallenges { get; set; }

        [JsonProperty("rewardTypes")]
        public List<string> RewardTypes { get; set; }
    }
}