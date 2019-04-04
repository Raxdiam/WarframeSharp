using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Simaris
    {
        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("isTargetActive")]
        public bool IsTargetActive { get; set; }

        [JsonProperty("asString")]
        public string AsString { get; set; }
    }
}