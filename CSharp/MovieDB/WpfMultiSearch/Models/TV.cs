// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WpfMultiSearch.JsonConverters;

namespace WpfMultiSearch.Models;

[DebuggerDisplay("[TV] {Name}")]
public sealed class TV : MediaBase
{
    [JsonPropertyName("first_air_date")]
    public string? FirstAirDate { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("origin_country")]
    public IList<string>? OriginCountry { get; set; }

    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }

    [JsonPropertyName("poster_path"), JsonConverter(typeof(JsonMovieImageUrlConverter))]
    public override Uri? PosterPath { get; set; }
}