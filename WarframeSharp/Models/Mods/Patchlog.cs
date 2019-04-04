using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Patchlog
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("imgUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImgUrl { get; set; }

        [JsonProperty("additions")]
        public string Additions { get; set; }

        [JsonProperty("changes")]
        public string Changes { get; set; }

        [JsonProperty("fixes")]
        public string Fixes { get; set; }
    }
}