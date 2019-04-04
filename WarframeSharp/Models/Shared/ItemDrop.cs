using Newtonsoft.Json;

namespace WarframeSharp
{
    public class ItemDrop : IDrop
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public Rarity Rarity { get; set; }

        [JsonProperty("chance", NullValueHandling = NullValueHandling.Ignore)]
        public double Chance { get; set; }

        [JsonProperty("rotation", NullValueHandling = NullValueHandling.Ignore)]
        public Rotation Rotation { get; set; }
    }
}