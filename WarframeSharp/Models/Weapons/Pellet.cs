using Newtonsoft.Json;

namespace WarframeSharp {
    public class Pellet
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}