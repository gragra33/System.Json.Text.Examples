// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WpfMultiSearch.Models;

public abstract class MediaBase : RecordBase
{
    //[JsonPropertyName("backdrop_path"),
    // JsonConverter(typeof(JsonPartialUrlConverter), Consts.UriPrefix)]
    public virtual Uri? BackdropPath { get; set; }

    [JsonPropertyName("genre_ids")]
    public IList<int>? GenreIds { get; set; }

    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    //[JsonPropertyName("poster_path"),
    // JsonConverter(typeof(JsonPartialUrlConverter), Consts.UriPrefix)]
    public virtual Uri? PosterPath { get; set; }

    [JsonPropertyName("vote_average")]
    public double? VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int? VoteCount { get; set; }
}