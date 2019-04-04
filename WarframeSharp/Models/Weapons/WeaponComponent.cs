using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp {
    public class WeaponComponent
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

        [JsonProperty("secondsPerShot", NullValueHandling = NullValueHandling.Ignore)]
        public double SecondsPerShot { get; set; }

        [JsonProperty("damagePerShot", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DamagePerShot { get; set; }

        [JsonProperty("magazineSize", NullValueHandling = NullValueHandling.Ignore)]
        public long MagazineSize { get; set; }

        [JsonProperty("reloadTime", NullValueHandling = NullValueHandling.Ignore)]
        public double ReloadTime { get; set; }

        [JsonProperty("totalDamage", NullValueHandling = NullValueHandling.Ignore)]
        public double TotalDamage { get; set; }

        [JsonProperty("damagePerSecond", NullValueHandling = NullValueHandling.Ignore)]
        public long DamagePerSecond { get; set; }

        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public string Trigger { get; set; }

        [JsonProperty("accuracy", NullValueHandling = NullValueHandling.Ignore)]
        public double Accuracy { get; set; }

        [JsonProperty("criticalChance", NullValueHandling = NullValueHandling.Ignore)]
        public double CriticalChance { get; set; }

        [JsonProperty("criticalMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double CriticalMultiplier { get; set; }

        [JsonProperty("procChance", NullValueHandling = NullValueHandling.Ignore)]
        public double ProcChance { get; set; }

        [JsonProperty("fireRate", NullValueHandling = NullValueHandling.Ignore)]
        public double FireRate { get; set; }

        [JsonProperty("chargeAttack", NullValueHandling = NullValueHandling.Ignore)]
        public long ChargeAttack { get; set; }

        [JsonProperty("spinAttack", NullValueHandling = NullValueHandling.Ignore)]
        public long SpinAttack { get; set; }

        [JsonProperty("leapAttack", NullValueHandling = NullValueHandling.Ignore)]
        public long LeapAttack { get; set; }

        [JsonProperty("wallAttack", NullValueHandling = NullValueHandling.Ignore)]
        public long WallAttack { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public long Slot { get; set; }

        [JsonProperty("noise", NullValueHandling = NullValueHandling.Ignore)]
        public Noise Noise { get; set; }

        [JsonProperty("sentinel", NullValueHandling = NullValueHandling.Ignore)]
        public bool Sentinel { get; set; }

        [JsonProperty("masteryReq", NullValueHandling = NullValueHandling.Ignore)]
        public long MasteryReq { get; set; }

        [JsonProperty("omegaAttenuation", NullValueHandling = NullValueHandling.Ignore)]
        public double OmegaAttenuation { get; set; }

        [JsonProperty("ducats", NullValueHandling = NullValueHandling.Ignore)]
        public long Ducats { get; set; }

        [JsonProperty("drops", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemDrop> Drops { get; set; }
    }
}