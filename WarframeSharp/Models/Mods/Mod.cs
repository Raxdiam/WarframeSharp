using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Mod
    {
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("polarity")]
        public Polarity Polarity { get; set; }

        [JsonProperty("rarity")]
        public Rarity Rarity { get; set; }

        [JsonProperty("baseDrain")]
        public long BaseDrain { get; set; }

        [JsonProperty("fusionLimit")]
        public long FusionLimit { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("type")]
        public ItemType Type { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("tradable")]
        public bool Tradable { get; set; }

        [JsonProperty("drops", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemDrop> Drops { get; set; }

        [JsonProperty("patchlogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Patchlog> Patchlogs { get; set; }

        [JsonProperty("upgradeEntries", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeEntry> UpgradeEntries { get; set; }

        [JsonProperty("availableChallenges", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailableChallenge> AvailableChallenges { get; set; }
    }
}