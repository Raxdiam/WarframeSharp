using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Complication
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("overrideTag", NullValueHandling = NullValueHandling.Ignore)]
        public string OverrideTag { get; set; }
    }
}