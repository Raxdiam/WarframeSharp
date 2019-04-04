using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class PolarityConverter : EnumConverter<Polarity>
    {
        public override Polarity ReadJson(JsonReader reader, Type objectType, Polarity existingValue,
                                          bool hasExistingValue,
                                          JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "AP_UMBRA":
                    return Polarity.ApUmbra;
                case "AP_UNIVERSAL":
                    return Polarity.ApUniversal;
                case "Madurai":
                    return Polarity.Madurai;
                case "Naramon":
                    return Polarity.Naramon;
                case "Penjaga":
                    return Polarity.Penjaga;
                case "Unairu":
                    return Polarity.Unairu;
                case "Vazarin":
                    return Polarity.Vazarin;
                case "Zenurik":
                    return Polarity.Zenurik;
                default:
                    return default;
            }
        }

        public static PolarityConverter Singleton = new PolarityConverter();
    }
}