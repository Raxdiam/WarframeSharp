using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Drop : IDrop
    {
        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("rarity")]
        public Rarity Rarity { get; set; }

        [JsonProperty("chance")]
        public double Chance { get; set; }
    }
}