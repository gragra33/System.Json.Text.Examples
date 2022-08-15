// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Support.CSharp.Json.Converters;

public sealed class JsonUnixTimespanToDateConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => int.TryParse(reader.GetString(), out int value)
            ? value > 0
                ? DateTime.UtcNow + new TimeSpan(0, 0, value)
                : DateTime.MaxValue
            : typeToConvert == typeof(TimeSpan)
                ? default
                : null;

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}