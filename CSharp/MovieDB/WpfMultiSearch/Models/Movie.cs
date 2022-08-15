// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WpfMultiSearch.JsonConverters;

namespace WpfMultiSearch.Models;

[DebuggerDisplay("[MOVIE] {Title}")]
public sealed class Movie : MediaBase
{
    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }

    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }

    [JsonPropertyName("poster_path"), JsonConverter(typeof(JsonMovieImageUrlConverter))]
    public override Uri? PosterPath { get; set; }

    [JsonPropertyName("release_date")]
    public string? ReleaseDate { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("video")]
    public bool? Video { get; set; }
}