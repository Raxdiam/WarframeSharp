using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class BooleanConverter : JsonConverter<bool>
    {
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer) => serializer.Serialize(writer, value);

        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value.ToLower().Trim())
            {
                case "true":
                case "1":
                case "n/a":
                    return true;
                default:
                    return false;
            }
        }
        
        public static BooleanConverter Singleton = new BooleanConverter();
    }
}
