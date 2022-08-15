// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Support.CSharp.Json.Converters;
using WpfPhoto.JsonConverters;

namespace WpfPhoto.Models;

[DebuggerDisplay("{Title}")]
public class Photo
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    [JsonPropertyName("originalsecret")]
    public string? OriginalSecret { get; set; }

    [JsonPropertyName("originalformat")]
    public string? OriginalFormat { get; set; }

    [JsonPropertyName("server")]
    public int? Server { get; set; }

    [JsonPropertyName("farm")]
    public int? Farm { get; set; }

    [JsonPropertyName("dateuploaded"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? DateUploaded { get; set; }

    [JsonPropertyName("date_faved"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? DateFavorited { get; set; }

    [JsonPropertyName("datepersonadded"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? DatePersonAdded { get; set; }

    [JsonPropertyName("isfavorite")]
    public bool? IsFavorite { get; set; }

    [JsonPropertyName("license")]
    public int? License { get; set; }

    [JsonPropertyName("safety_level")]
    public int? SafetyLevel { get; set; }

    [JsonPropertyName("rotation")]
    public int? Rotation { get; set; }

    [JsonPropertyName("title"), JsonConverter(typeof(JsonFlickrContentConverter<string?>))]
    public string? Title { get; set; }

    [JsonPropertyName("description"), JsonConverter(typeof(JsonFlickrContentConverter<string?>))]
    public string? Description { get; set; }

    [JsonPropertyName("visibility")]
    public Visibility? Visibility { get; set; }

    [JsonPropertyName("views")]
    public int? Views { get; set; }

    [JsonPropertyName("publiceditability")]
    public PublicEditability? PublicEditability { get; set; }

    [JsonPropertyName("usage")]
    public Usage? Usage { get; set; }

    [JsonPropertyName("comments"), JsonConverter(typeof(JsonFlickrContentConverter<int?>))]
    public int? Comments { get; set; }

    [JsonPropertyName("notes"), JsonConverter(typeof(JsonFlickrCollectionConverter<Note>))]
    public List<Note>? Notes { get; set; }

    [JsonPropertyName("people")]
    public Person? People { get; set; }

    [JsonPropertyName("urls"), JsonConverter(typeof(JsonFlickrCollectionConverter<Url>))]
    public List<Url>? Urls { get; set; }

    [JsonPropertyName("media")]
    public string? Media { get; set; }

    [JsonPropertyName("media_status")]
    public string? MediaStatus { get; set; }

    [JsonPropertyName("owner")]
    public Owner? Owner { get; set; }

    [JsonPropertyName("location")]
    public Location? Location { get; set; }

    [JsonPropertyName("tags"), JsonConverter(typeof(JsonFlickrCollectionConverter<Tag>))]
    public List<Tag>? Tags { get; set; }

    //[JsonPropertyName("dates")]
    //public Dates? Dates { get; set; }

    [JsonPropertyName("editability")]
    public Editability? Editability { get; set; }

    [JsonPropertyName("geoperms")]
    public Geoperms? Geoperms { get; set; }

    [JsonPropertyName("sizes")]
    public Sizes? Sizes { get; set; }
}