// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Support.CSharp.Json.Converters;

public sealed class JsonStringBoolConverter  : JsonConverter<bool>
{
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => reader.TokenType switch
        {
            JsonTokenType.True => true,
            JsonTokenType.False => false,
            JsonTokenType.String => bool.TryParse(reader.GetString(), out bool b)
                ? b
                : throw new JsonException(),
            JsonTokenType.Number => reader.TryGetInt64(out long l)
                ? Convert.ToBoolean(l)
                : reader.TryGetDouble(out double d) && Convert.ToBoolean(d),
            _ => throw new JsonException()
        };

    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        => writer.WriteBooleanValue(value);
}