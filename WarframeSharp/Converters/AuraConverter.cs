using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class AuraConverter : EnumConverter<Aura>
    {
        public override Aura ReadJson(JsonReader reader, Type objectType, Aura existingValue, bool hasExistingValue,
                                      JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "madurai":
                    return Aura.Madurai;
                case "naramon":
                    return Aura.Naramon;
                case "umbra":
                    return Aura.Umbra;
                case "vazarin":
                    return Aura.Vazarin;
                default:
                    return default;
            }
        }

        public static AuraConverter Singleton = new AuraConverter();
    }
}