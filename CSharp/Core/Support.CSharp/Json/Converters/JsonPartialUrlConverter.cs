// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Support.CSharp.Json.Converters;

public class JsonPartialUrlConverter : JsonConverter<Uri?>
{
    public JsonPartialUrlConverter(string prefixUri)
        => prefix = prefixUri;

    private readonly string prefix;

    public override Uri? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => reader.TokenType == JsonTokenType.String && !string.IsNullOrWhiteSpace(reader.GetString())
            ? new Uri(prefix + reader.GetString())
            : null;

    public override void Write(Utf8JsonWriter writer, Uri? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}