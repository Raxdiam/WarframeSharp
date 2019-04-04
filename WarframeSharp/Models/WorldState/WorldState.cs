using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class WorldState
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("news")]
        public List<News> News { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("alerts"), Obsolete("Warframe has replaced the old alert system with Nightwave.", false)]
        public List<object> Alerts { get; set; }

        [JsonProperty("sortie")]
        public Sortie Sortie { get; set; }

        [JsonProperty("syndicateMissions")]
        public List<SyndicateMission> SyndicateMissions { get; set; }

        [JsonProperty("fissures")]
        public List<Fissure> Fissures { get; set; }

        [JsonProperty("globalUpgrades")]
        public List<object> GlobalUpgrades { get; set; }

        [JsonProperty("flashSales")]
        public List<FlashSale> FlashSales { get; set; }

        [JsonProperty("invasions")]
        public List<Invasion> Invasions { get; set; }

        [JsonProperty("darkSectors")]
        public List<DarkSector> DarkSectors { get; set; }

        [JsonProperty("voidTrader")]
        public VoidTrader VoidTrader { get; set; }

        [JsonProperty("dailyDeals")]
        public List<DailyDeal> DailyDeals { get; set; }

        [JsonProperty("simaris")]
        public Simaris Simaris { get; set; }

        [JsonProperty("conclaveChallenges")]
        public List<ConclaveChallenge> ConclaveChallenges { get; set; }

        [JsonProperty("persistentEnemies")]
        public List<object> PersistentEnemies { get; set; }

        [JsonProperty("earthCycle")]
        public EarthCycle EarthCycle { get; set; }

        [JsonProperty("cetusCycle")]
        public CetusCycle CetusCycle { get; set; }

        [JsonProperty("weeklyChallenges")]
        public List<object> WeeklyChallenges { get; set; }

        [JsonProperty("constructionProgress")]
        public ConstructionProgress ConstructionProgress { get; set; }

        [JsonProperty("vallisCycle")]
        public VallisCycle VallisCycle { get; set; }

        [JsonProperty("nightwave")]
        public Nightwave Nightwave { get; set; }
    }
}