using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class CategoryConverter : EnumConverter<Category>
    {
        public override Category ReadJson(JsonReader reader, Type objectType, Category existingValue,
                                          bool hasExistingValue,
                                          JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "Mods":
                    return Category.Mods;
                case "Warframes":
                    return Category.Warframes;
                case "Melee":
                    return Category.Melee;
                case "Primary":
                    return Category.Primary;
                case "Secondary":
                    return Category.Secondary;
                default:
                    return default;
            }
        }

        public static CategoryConverter Singleton = new CategoryConverter();
    }
}