using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class ItemTypeConverter : EnumConverter<ItemType>
    {
        public override ItemType ReadJson(JsonReader reader, Type objectType, ItemType existingValue,
                                          bool hasExistingValue,
                                          JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "---":
                    return ItemType.Empty;
                case "Archwing":
                    return ItemType.Archwing;
                case "Aura":
                    return ItemType.Aura;
                case "Focus Lens":
                    return ItemType.FocusLens;
                case "Kavat":
                    return ItemType.Kavat;
                case "Kubrow":
                    return ItemType.Kubrow;
                case "Melee":
                    return ItemType.Melee;
                case "Misc":
                    return ItemType.Misc;
                case "Pets":
                    return ItemType.Pets;
                case "Primary":
                    return ItemType.Primary;
                case "Rifle":
                    return ItemType.Rifle;
                case "Secondary":
                    return ItemType.Secondary;
                case "Sentinel":
                    return ItemType.Sentinel;
                case "Shotgun":
                    return ItemType.Shotgun;
                case "Stance":
                    return ItemType.Stance;
                case "Warframe":
                    return ItemType.Warframe;
                default:
                    return default;
            }
        }

        public static ItemTypeConverter Singleton = new ItemTypeConverter();
    }
}