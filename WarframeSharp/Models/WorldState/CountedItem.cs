using Newtonsoft.Json;

namespace WarframeSharp
{
    public class CountedItem
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}