using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class News
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("imageLink")]
        public Uri ImageLink { get; set; }

        [JsonProperty("priority")]
        public bool Priority { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("update")]
        public bool Update { get; set; }

        [JsonProperty("primeAccess")]
        public bool PrimeAccess { get; set; }

        [JsonProperty("stream")]
        public bool Stream { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        [JsonProperty("asString")]
        public string AsString { get; set; }
    }
}