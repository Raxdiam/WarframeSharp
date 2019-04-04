using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Job
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rewardPool")]
        public List<string> RewardPool { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enemyLevels")]
        public List<long> EnemyLevels { get; set; }

        [JsonProperty("standingStages")]
        public List<long> StandingStages { get; set; }
    }
}