using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WarframeSharp.Converters;

namespace WarframeSharp
{
    public class Weapon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("secondsPerShot")]
        public double SecondsPerShot { get; set; }

        [JsonProperty("damagePerShot")]
        public List<double> DamagePerShot { get; set; }

        [JsonProperty("magazineSize")]
        public long MagazineSize { get; set; }

        [JsonProperty("reloadTime")]
        public double ReloadTime { get; set; }

        [JsonProperty("totalDamage")]
        public double TotalDamage { get; set; }

        [JsonProperty("damagePerSecond")]
        public long DamagePerSecond { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("criticalChance")]
        public double CriticalChance { get; set; }

        [JsonProperty("criticalMultiplier")]
        public double CriticalMultiplier { get; set; }

        [JsonProperty("procChance")]
        public double ProcChance { get; set; }

        [JsonProperty("fireRate")]
        public double FireRate { get; set; }

        [JsonProperty("chargeAttack")]
        public long ChargeAttack { get; set; }

        [JsonProperty("spinAttack")]
        public long SpinAttack { get; set; }

        [JsonProperty("leapAttack")]
        public long LeapAttack { get; set; }

        [JsonProperty("wallAttack")]
        public long WallAttack { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("noise")]
        public Noise Noise { get; set; }

        [JsonProperty("sentinel")]
        public bool Sentinel { get; set; }

        [JsonProperty("masteryReq")]
        public long MasteryReq { get; set; }

        [JsonProperty("omegaAttenuation")]
        public double OmegaAttenuation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("buildPrice", NullValueHandling = NullValueHandling.Ignore)]
        public long BuildPrice { get; set; }

        [JsonProperty("buildTime", NullValueHandling = NullValueHandling.Ignore)]
        public long BuildTime { get; set; }

        [JsonProperty("skipBuildTimePrice", NullValueHandling = NullValueHandling.Ignore)]
        public long SkipBuildTimePrice { get; set; }

        [JsonProperty("buildQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public long BuildQuantity { get; set; }

        [JsonProperty("consumeOnBuild", NullValueHandling = NullValueHandling.Ignore)]
        public bool ConsumeOnBuild { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<WeaponComponent> Components { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("tradable")]
        public bool Tradable { get; set; }

        [JsonProperty("patchlogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Patchlog> Patchlogs { get; set; }

        [JsonProperty("channeling", NullValueHandling = NullValueHandling.Ignore)]
        public double Channeling { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(BasicTypeConverter<double>))]
        public double Damage { get; set; }

        [JsonProperty("damageTypes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> DamageTypes { get; set; }

        [JsonProperty("marketCost", NullValueHandling = NullValueHandling.Ignore)]
        public double MarketCost { get; set; }

        [JsonProperty("polarities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Polarity> Polarities { get; set; }

        [JsonProperty("stancePolarity", NullValueHandling = NullValueHandling.Ignore)]
        public Polarity StancePolarity { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("vaulted", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(BooleanConverter))]
        public bool Vaulted { get; set; }

        [JsonProperty("wikiaThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri WikiaThumbnail { get; set; }

        [JsonProperty("wikiaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri WikiaUrl { get; set; }

        [JsonProperty("disposition", NullValueHandling = NullValueHandling.Ignore)]
        public long Disposition { get; set; }

        [JsonProperty("ammo", NullValueHandling = NullValueHandling.Ignore)]
        public long Ammo { get; set; }

        [JsonProperty("flight", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(BasicTypeConverter<long>))]
        public long Flight { get; set; }

        [JsonProperty("projectile", NullValueHandling = NullValueHandling.Ignore)]
        public Projectile Projectile { get; set; }

        [JsonProperty("releaseDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDate { get; set; }

        [JsonProperty("vaultDate", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultDate { get; set; }

        [JsonProperty("estimatedVaultDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedVaultDate { get; set; }

        [JsonProperty("secondary", NullValueHandling = NullValueHandling.Ignore)]
        public Secondary Secondary { get; set; }

        [JsonProperty("secondaryArea", NullValueHandling = NullValueHandling.Ignore)]
        public SecondaryArea SecondaryArea { get; set; }

        [JsonProperty("statusChance", NullValueHandling = NullValueHandling.Ignore)]
        public long StatusChance { get; set; }
    }
}
