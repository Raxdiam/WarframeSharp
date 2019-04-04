using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class RarityConverter : EnumConverter<Rarity>
    {
        public override Rarity ReadJson(JsonReader reader, Type objectType, Rarity existingValue, bool hasExistingValue,
                                        JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "Common":
                    return Rarity.Common;
                case "Rare":
                    return Rarity.Rare;
                case "Uncommon":
                    return Rarity.Uncommon;
                case "Legendary":
                    return Rarity.Legendary;
                default:
                    return default;
            }
        }

        public static readonly RarityConverter Singleton = new RarityConverter();
    }
}