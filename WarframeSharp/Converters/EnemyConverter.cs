using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class EnemyConverter : EnumConverter<Enemy>
    {
        public override Enemy ReadJson(JsonReader reader, Type objectType, Enemy existingValue, bool hasExistingValue,
                                       JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return Enemy.Unknown;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "Corpus":
                    return Enemy.Corpus;
                case "Grineer":
                    return Enemy.Grineer;
                case "Infested":
                    return Enemy.Infested;
                case "Orokin":
                    return Enemy.Orokin;
                default:
                    return Enemy.Unknown;
            }
        }

        public static readonly EnemyConverter Singleton = new EnemyConverter();
    }
}