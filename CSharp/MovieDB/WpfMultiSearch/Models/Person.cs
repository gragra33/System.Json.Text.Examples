// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WpfMultiSearch.JsonConverters;

namespace WpfMultiSearch.Models;

[DebuggerDisplay("[PERSON] {Name}")]
public sealed class Person : RecordBase
{
    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }

    [JsonPropertyName("known_for"), JsonConverter(typeof(JsonDataTypeConverter))]
    public List<IDataType>? KnownFor { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("profile_path"), JsonConverter(typeof(JsonMovieImageUrlConverter))]
    public Uri? ProfilePath { get; set; }
}