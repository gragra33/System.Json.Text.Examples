// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WpfPhoto.JsonConverters;

public class JsonFlickrCollectionConverter<TModel> : JsonConverter<List<TModel>?> where TModel : class
{
    public override List<TModel> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        // position reader

        reader.Read(); // move to property name
        reader.Read(); // move to start of the array

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        List<TModel> items = new();

        // Walk through all of the items in the array
        while (reader.TokenType != JsonTokenType.EndArray)
            items.AddRange(JsonSerializer.Deserialize<List<TModel>>(ref reader, options)!);

        reader.Read(); // move to EndObject

        return items;
    }

    public override void Write(Utf8JsonWriter writer, List<TModel>? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}