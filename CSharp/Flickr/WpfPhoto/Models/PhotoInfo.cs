// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using WpfPhoto.JsonConverters;

namespace WpfPhoto.Models;

public class PhotoInfo
{
    [JsonPropertyName("id")]
    private string? Id { set => nsid = value; }
    private string? nsid;

    [JsonPropertyName("_content")]
    public string? NsId { get => nsid; set => nsid = value; }

    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    [JsonPropertyName("originalsecret")]
    public string? Originalsecret { get; set; }

    [JsonPropertyName("firstdatetaken"), JsonConverter(typeof(JsonFlickrContentConverter<DateTime?>))]
    public DateTime? FirstDateTaken { get; set; }

    [JsonPropertyName("firstdate"), JsonConverter(typeof(JsonFlickrUnixDateContentConverter))]
    public DateTime? FirstDate { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("fromdate")]
    public string? FromDate { get; set; }

    [JsonPropertyName("todate")]
    public string? ToDate { get; set; }

    [JsonPropertyName("person")]
    public IList<Person>? Person { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }

    [JsonPropertyName("farm")]
    public int? Farm { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("pages")]
    public int? Pages { get; set; }

    [JsonPropertyName("perpage")]
    public int? PerPage { get; set; }

    [JsonPropertyName("total")]
    public string? Total { get; set; }
}