using System;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class ProjectileConverter : EnumConverter<Projectile>
    {
        public override Projectile ReadJson(JsonReader reader, Type objectType, Projectile existingValue, bool hasExistingValue,
                                            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Discharge":
                    return Projectile.Discharge;
                case "Hitscan":
                    return Projectile.Hitscan;
                case "Projectile":
                    return Projectile.Projectile;
                case "Thrown":
                    return Projectile.Thrown;
                default:
                    return default;
            }
        }

        public static ProjectileConverter Singleton = new ProjectileConverter();
    }
}
