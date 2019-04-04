using Newtonsoft.Json;

namespace WarframeSharp.Converters
{
    internal abstract class EnumConverter<T> : JsonConverter<T>
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            if (value == null) {
                serializer.Serialize(writer, null);
                return;
            }

            serializer.Serialize(writer, value.ToString());
        }
    }
}