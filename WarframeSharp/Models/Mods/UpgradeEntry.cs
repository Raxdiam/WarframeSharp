using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class UpgradeEntry
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("prefixTag")]
        public string PrefixTag { get; set; }

        [JsonProperty("suffixTag")]
        public string SuffixTag { get; set; }

        [JsonProperty("upgradeValues")]
        public List<UpgradeValue> UpgradeValues { get; set; }
    }
}