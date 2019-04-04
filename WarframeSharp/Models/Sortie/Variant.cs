using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Variant
    {
        [JsonProperty("boss")]
        public string Boss { get; set; }

        [JsonProperty("planet")]
        public string Planet { get; set; }

        [JsonProperty("missionType")]
        public string MissionType { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("modifierDescription")]
        public string ModifierDescription { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }
    }
}