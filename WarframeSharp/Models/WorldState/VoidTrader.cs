using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class VoidTrader
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTimeOffset Activation { get; set; }

        [JsonProperty("startString")]
        public string StartString { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("inventory")]
        public List<object> Inventory { get; set; }

        [JsonProperty("psId")]
        public string PsId { get; set; }

        [JsonProperty("endString")]
        public string EndString { get; set; }
    }
}