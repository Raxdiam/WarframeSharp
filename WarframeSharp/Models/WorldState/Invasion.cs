using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Invasion
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTimeOffset Activation { get; set; }

        [JsonProperty("startString")]
        public string StartString { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("attackerReward")]
        public Reward AttackerReward { get; set; }

        [JsonProperty("attackingFaction")]
        public Enemy AttackingFaction { get; set; }

        [JsonProperty("defenderReward")]
        public Reward DefenderReward { get; set; }

        [JsonProperty("defendingFaction")]
        public Enemy DefendingFaction { get; set; }

        [JsonProperty("vsInfestation")]
        public bool VsInfestation { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("requiredRuns")]
        public long RequiredRuns { get; set; }

        [JsonProperty("completion")]
        public double Completion { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("rewardTypes")]
        public List<string> RewardTypes { get; set; }
    }
}