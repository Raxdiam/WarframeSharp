using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class SexConverter : EnumConverter<Sex>
    {
        public override Sex ReadJson(JsonReader reader, Type objectType, Sex existingValue, bool hasExistingValue,
                                     JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "Female":
                    return Sex.Female;
                case "Male":
                    return Sex.Male;
                default:
                    return default;
            }
        }

        public static SexConverter Singleton = new SexConverter();
    }
}