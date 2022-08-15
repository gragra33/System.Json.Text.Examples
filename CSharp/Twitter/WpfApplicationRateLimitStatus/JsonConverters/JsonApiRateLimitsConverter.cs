// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using WpfApplicationRateLimitStatus.Models;

namespace WpfApplicationRateLimitStatus.JsonConverters;

public sealed class JsonApiRateLimitsConverter : JsonConverter<ObservableCollection<RateCategoryModel>?>
{
    public override ObservableCollection<RateCategoryModel>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            return default;

        ObservableCollection<RateCategoryModel> items = new();

        foreach (KeyValuePair<string, JsonNode?> jsonObject in JsonSerializer
                     .Deserialize<JsonObject>(ref reader, options)!)

            if (ProcessChild(jsonObject, options) is { } rate)
                items.Add(rate);

        return items.Count > 0
            ? items
            : default;
    }

    private RateCategoryModel ProcessChild(KeyValuePair<string, JsonNode?> jsonObject, JsonSerializerOptions options)
    {
        RateCategoryModel rate = new() { Name = jsonObject.Key };

        foreach (KeyValuePair<string, JsonNode?> child in jsonObject.Value.Deserialize<JsonObject>(options)!)
        {
            ApiRateLimitModel? limit = child.Value.Deserialize<ApiRateLimitModel>(options);

            if (limit is null)
                continue;

            rate.Limits.Add(new()
            {
                Name = GetPropertyName(child.Key),
                Limit = limit
            });
        }

        return rate;
    }

    private static string GetPropertyName(string value)
    {
        string name = "__no_name__";

        if (!string.IsNullOrEmpty(value))
        {
            string[] parts = value.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            name = string.Join("_", parts.Skip(1)).Replace(":", "");

            if (string.IsNullOrEmpty(name))
                name = parts[0];
        }

        return name;
    }
    
    public override void Write(Utf8JsonWriter writer, ObservableCollection<RateCategoryModel>? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}