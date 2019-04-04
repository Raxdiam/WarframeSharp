using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class NoiseConverter : EnumConverter<Noise>
    {
        public override Noise ReadJson(JsonReader reader, Type objectType, Noise existingValue, bool hasExistingValue,
                                       JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Alarming":
                    return Noise.Alarming;
                case "Silent":
                    return Noise.Silent;
                default:
                    return default;
            }
        }

        public static NoiseConverter Singleton = new NoiseConverter();
    }
}
