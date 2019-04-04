using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WarframeSharp.Converters
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                EnemyConverter.Singleton,
                RarityConverter.Singleton,
                RotationConverter.Singleton,
                PolarityConverter.Singleton,
                ItemTypeConverter.Singleton,
                AuraConverter.Singleton,
                CategoryConverter.Singleton,
                SexConverter.Singleton,
                NoiseConverter.Singleton,
                ProjectileConverter.Singleton,
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };
    }
}