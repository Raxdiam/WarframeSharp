using Newtonsoft.Json;

namespace WarframeSharp {
    public class SecondaryArea
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status_chance", NullValueHandling = NullValueHandling.Ignore)]
        public double StatusChance { get; set; }

        [JsonProperty("pellet", NullValueHandling = NullValueHandling.Ignore)]
        public Pellet Pellet { get; set; }

        [JsonProperty("blast", NullValueHandling = NullValueHandling.Ignore)]
        public long Blast { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public long Radius { get; set; }

        [JsonProperty("heat", NullValueHandling = NullValueHandling.Ignore)]
        public long Heat { get; set; }

        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public double Speed { get; set; }

        [JsonProperty("radiation", NullValueHandling = NullValueHandling.Ignore)]
        public long Radiation { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long Duration { get; set; }
    }
}