// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using WpfUserAgent.Models;

namespace WpfUserAgent.JsonConverters;

public class UserAgentPluginsConverter : JsonConverter<List<PluginModel>?>
{
    public override List<PluginModel>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            return default;

        List<PluginModel>? plugins = new();

        foreach (KeyValuePair<string, JsonNode?> jsonObject in JsonSerializer.Deserialize<JsonObject>(ref reader, options)!)
            plugins.Add(new()
            {
                Id = jsonObject.Key,
                Values =  GetValues(jsonObject.Value)
            });

        return plugins;
    }

    private List<PluginObjectModel> GetValues(JsonNode? jsonNode)
    {
        List<PluginObjectModel> objects = new();

        foreach (KeyValuePair<string, JsonNode?> node in jsonNode.Deserialize<JsonObject>()!)
        {
            objects.Add(new()
            {
                Id = node.Key,
                Value = node.Value.Deserialize<object>()
            });
        }

        return objects;
    }

    public override void Write(Utf8JsonWriter writer, List<PluginModel>? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}