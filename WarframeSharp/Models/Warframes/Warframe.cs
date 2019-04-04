using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WarframeSharp.Converters;

namespace WarframeSharp
{
    public class Warframe
    {
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("health")]
        public long Health { get; set; }

        [JsonProperty("shield")]
        public long Shield { get; set; }

        [JsonProperty("armor")]
        public long Armor { get; set; }

        [JsonProperty("stamina")]
        public long Stamina { get; set; }

        [JsonProperty("power")]
        public long Power { get; set; }

        [JsonProperty("passiveDescription")]
        public string PassiveDescription { get; set; }

        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonProperty("type")]
        public ItemType Type { get; set; }

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
        public List<WarframeComponent> Components { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("tradable")]
        public bool Tradable { get; set; }

        [JsonProperty("patchlogs")]
        public List<Patchlog> Patchlogs { get; set; }

        [JsonProperty("aura", NullValueHandling = NullValueHandling.Ignore)]
        public Aura Aura { get; set; }

        [JsonProperty("conclave")]
        public bool Conclave { get; set; }

        [JsonProperty("color")]
        public long Color { get; set; }

        [JsonProperty("introduced")]
        public string Introduced { get; set; }

        [JsonProperty("masteryReq")]
        public long MasteryReq { get; set; }

        [JsonProperty("polarities")]
        public List<Aura> Polarities { get; set; }

        [JsonProperty("sex")]
        public Sex Sex { get; set; }

        [JsonProperty("sprint")]
        public double Sprint { get; set; }

        [JsonProperty("wikiaThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri WikiaThumbnail { get; set; }

        [JsonProperty("wikiaUrl")]
        public Uri WikiaUrl { get; set; }

        [JsonProperty("vaulted"), JsonConverter(typeof(BooleanConverter))]
        public bool Vaulted { get; set; }

        [JsonProperty("releaseDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDate { get; set; }

        [JsonProperty("vaultDate", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultDate { get; set; }

        [JsonProperty("estimatedVaultDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedVaultDate { get; set; }
    }
}