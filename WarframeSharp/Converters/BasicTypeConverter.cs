using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal class BasicTypeConverter<T> : JsonConverter<T> where T : struct
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) => serializer.Serialize(writer, value);

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return default;
            var value = serializer.Deserialize<string>(reader);
            
            try {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                return (T?) converter.ConvertFromString(value) ?? default;
            }
            catch {
                return default;
            }
        }
    }
}
