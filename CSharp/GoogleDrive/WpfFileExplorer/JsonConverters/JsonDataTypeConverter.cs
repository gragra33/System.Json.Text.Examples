// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using WpfFileExplorer.Models;

namespace WpfFileExplorer.JsonConverters;

public sealed class JsonDataTypeConverter : JsonConverter<List<File>?>
{
    public override List<File>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            return default;

        List<File> items = new();

        // walk through all of the items in the collection
        foreach (JsonObject jsonObject in JsonSerializer.Deserialize<List<JsonObject>>(ref reader, options)!)
        {
            // Deserialize based on kind field
            string? kind = jsonObject["kind"]?.GetValue<string>();

            if (string.IsNullOrEmpty(kind))
                continue;

            if (kind.Equals("drive#file"))
                ProcessFileType(jsonObject, items);
        }

        return items;
    }

    // polymorphic deserialization
    private void ProcessFileType(JsonObject jsonObject, List<File> items)
    {
        // Deserialize based on mimeType field
        string? mimeType = jsonObject["mimeType"]?.GetValue<string>();

        if (string.IsNullOrEmpty(mimeType))
            return;

        items.Add(MimeToFileConverter.Types[mimeType](jsonObject));
    }

    public override void Write(Utf8JsonWriter writer, List<File>? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}