using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Arcane
    {
        [JsonProperty("regex")]
        public string Regex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("rarity")]
        public Rarity Rarity { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("thumbnail")]
        public Uri Thumbnail { get; set; }

        [JsonProperty("info")]
        public Uri Info { get; set; }
    }
}