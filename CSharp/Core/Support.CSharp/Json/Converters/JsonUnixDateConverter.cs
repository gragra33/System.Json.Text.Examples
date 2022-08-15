// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Support.CSharp.Json.Converters;

public sealed class JsonUnixDateConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => reader.TokenType switch
        {
            JsonTokenType.Number => reader.GetDouble().FromUnixDate(),
            JsonTokenType.String => double.TryParse(reader.GetString(), out var value)
                ? value.FromUnixDate()
                : typeToConvert == typeof(DateTime)
                    ? default
                    : null,
            _ => throw new JsonException()
        };

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}