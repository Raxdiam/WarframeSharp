using Newtonsoft.Json;

namespace WarframeSharp
{
    public class ConstructionProgress
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fomorianProgress")]
        public string FomorianProgress { get; set; }

        [JsonProperty("razorbackProgress")]
        public string RazorbackProgress { get; set; }

        [JsonProperty("unknownProgress")]
        public string UnknownProgress { get; set; }
    }
}