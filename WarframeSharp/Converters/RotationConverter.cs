using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class RotationConverter : EnumConverter<Rotation>
    {
        public override Rotation ReadJson(JsonReader reader, Type objectType, Rotation existingValue,
                                          bool hasExistingValue,
                                          JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "(Extra)":
                    return Rotation.Extra;
                case "A":
                    return Rotation.A;
                case "Annihilation":
                    return Rotation.Annihilation;
                case "B":
                    return Rotation.B;
                case "C":
                    return Rotation.C;
                case "Capture":
                    return Rotation.Capture;
                case "Onslaught":
                    return Rotation.Onslaught;
                case "Sabotage":
                    return Rotation.Sabotage;
                case "rewards":
                    return Rotation.Rewards;
                default:
                    return default;
            }
        }

        public static readonly RotationConverter Singleton = new RotationConverter();
    }
}