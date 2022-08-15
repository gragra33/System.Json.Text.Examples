// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using WpfMultiSearch.Models;

namespace WpfMultiSearch.JsonConverters;

public class JsonDataTypeConverter : JsonConverter<List<IDataType>?>
{
    public override List<IDataType>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            return default;

        // polymorphic deserialization
        List<IDataType>? items = default;

        // walk through all of the items in the collection
        foreach (JsonObject jsonObject in JsonSerializer.Deserialize<List<JsonObject>>(ref reader, options)!)
        {
            // Deserialize based on media_type field
            IDataType? item = jsonObject["media_type"]?.GetValue<string>() switch
            {
                "tv" => jsonObject.Deserialize<TV>(options)!,
                "movie" => jsonObject.Deserialize<Movie>(options)!,
                "person" => jsonObject.Deserialize<Person>(options)!,
                _ => null
            };

            if (item is null) continue;

            items ??= new();
            items.Add(item);
        }

        return items;
    }

    public override void Write(Utf8JsonWriter writer, List<IDataType>? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}