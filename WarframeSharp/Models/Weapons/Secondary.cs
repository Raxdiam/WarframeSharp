using Newtonsoft.Json;

namespace WarframeSharp {
    public class Secondary
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("pellet", NullValueHandling = NullValueHandling.Ignore)]
        public Pellet Pellet { get; set; }

        [JsonProperty("blast", NullValueHandling = NullValueHandling.Ignore)]
        public long Blast { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore)]
        public string Damage { get; set; }

        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public double Speed { get; set; }

        [JsonProperty("crit_chance", NullValueHandling = NullValueHandling.Ignore)]
        public double CritChance { get; set; }

        [JsonProperty("crit_mult", NullValueHandling = NullValueHandling.Ignore)]
        public double CritMult { get; set; }

        [JsonProperty("status_chance", NullValueHandling = NullValueHandling.Ignore)]
        public double StatusChance { get; set; }

        [JsonProperty("shot_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShotType { get; set; }

        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public double Impact { get; set; }

        [JsonProperty("slash", NullValueHandling = NullValueHandling.Ignore)]
        public double Slash { get; set; }

        [JsonProperty("puncture", NullValueHandling = NullValueHandling.Ignore)]
        public double Puncture { get; set; }

        [JsonProperty("shot_speed", NullValueHandling = NullValueHandling.Ignore)]
        public long ShotSpeed { get; set; }

        [JsonProperty("charge_time", NullValueHandling = NullValueHandling.Ignore)]
        public double ChargeTime { get; set; }

        [JsonProperty("radiation", NullValueHandling = NullValueHandling.Ignore)]
        public long Radiation { get; set; }

        [JsonProperty("toxin", NullValueHandling = NullValueHandling.Ignore)]
        public long Toxin { get; set; }

        [JsonProperty("corrosive", NullValueHandling = NullValueHandling.Ignore)]
        public long Corrosive { get; set; }

        [JsonProperty("electricity", NullValueHandling = NullValueHandling.Ignore)]
        public long Electricity { get; set; }
    }
}