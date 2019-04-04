using Newtonsoft.Json;

namespace WarframeSharp
{
    public class UpgradeValue
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("locTag", NullValueHandling = NullValueHandling.Ignore)]
        public string LocTag { get; set; }
    }
}