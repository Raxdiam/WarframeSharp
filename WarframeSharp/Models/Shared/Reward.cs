using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Reward
    {
        [JsonProperty("items")]
        public List<string> Items { get; set; }

        [JsonProperty("countedItems")]
        public List<CountedItem> CountedItems { get; set; }

        [JsonProperty("credits")]
        public long Credits { get; set; }

        [JsonProperty("asString")]
        public string AsString { get; set; }

        [JsonProperty("itemString")]
        public string ItemString { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("color")]
        public long Color { get; set; }
    }
}