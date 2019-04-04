using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class AvailableChallenge
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("complications")]
        public List<Complication> Complications { get; set; }
    }
}