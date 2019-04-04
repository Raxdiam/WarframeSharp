using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Translations
    {
        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public string Fr { get; set; }

        [JsonProperty("it", NullValueHandling = NullValueHandling.Ignore)]
        public string It { get; set; }

        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public string De { get; set; }

        [JsonProperty("es", NullValueHandling = NullValueHandling.Ignore)]
        public string Es { get; set; }

        [JsonProperty("pt", NullValueHandling = NullValueHandling.Ignore)]
        public string Pt { get; set; }

        [JsonProperty("ru", NullValueHandling = NullValueHandling.Ignore)]
        public string Ru { get; set; }

        [JsonProperty("tr", NullValueHandling = NullValueHandling.Ignore)]
        public string Tr { get; set; }

        [JsonProperty("ja", NullValueHandling = NullValueHandling.Ignore)]
        public string Ja { get; set; }

        [JsonProperty("zh", NullValueHandling = NullValueHandling.Ignore)]
        public string Zh { get; set; }

        [JsonProperty("ko", NullValueHandling = NullValueHandling.Ignore)]
        public string Ko { get; set; }

        [JsonProperty("tc", NullValueHandling = NullValueHandling.Ignore)]
        public string Tc { get; set; }

        [JsonProperty("pl", NullValueHandling = NullValueHandling.Ignore)]
        public string Pl { get; set; }
    }
}