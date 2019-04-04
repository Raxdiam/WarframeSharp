using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class WarframeComponent
    {
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("itemCount")]
        public long ItemCount { get; set; }

        [JsonProperty("tradable")]
        public bool Tradable { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("drops", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemDrop> Drops { get; set; }

        [JsonProperty("ducats", NullValueHandling = NullValueHandling.Ignore)]
        public long Ducats { get; set; }
    }
}