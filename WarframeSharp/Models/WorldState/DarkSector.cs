using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class DarkSector
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isAlliance")]
        public bool IsAlliance { get; set; }

        [JsonProperty("defenderName")]
        public string DefenderName { get; set; }

        [JsonProperty("defenderDeployemntActivation")]
        public long DefenderDeployemntActivation { get; set; }

        [JsonProperty("defenderMOTD")]
        public string DefenderMotd { get; set; }

        [JsonProperty("deployerName")]
        public string DeployerName { get; set; }

        [JsonProperty("deployerClan", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployerClan { get; set; }

        [JsonProperty("history")]
        public List<object> History { get; set; }
    }
}