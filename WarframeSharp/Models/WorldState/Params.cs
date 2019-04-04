using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Params
    {
        [JsonProperty("wgsc")]
        public int Wgsc { get; set; }

        [JsonProperty("wsr")]
        public double Wsr { get; set; }

        public int Wcc { get; set; }
    }
}