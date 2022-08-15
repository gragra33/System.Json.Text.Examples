// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WpfFileExplorer.JsonConverters;

public sealed class JsonGoogleUriContentConverter : JsonConverter<Uri?>
{
    public override Uri? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();
        return (string.IsNullOrEmpty(value))
            ? null
            : new Uri(value.StartsWith("//") ? $"https:{value}" : value);
    }

    public override void Write(Utf8JsonWriter writer, Uri? value, JsonSerializerOptions options) => throw new NotImplementedException();
}