// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Text.Json.Serialization;
using Support.CSharp.Json.Converters;

namespace WpfPhoto.Models;

public class Dates
{
    [JsonPropertyName("posted"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? Posted { get; set; }

    [JsonPropertyName("taken")]
    public DateTime? Taken { get; set; }

    [JsonPropertyName("takengranularity")]
    public int? TakenGranularity { get; set; }

    [JsonPropertyName("takenunknown")]
    public bool? TakenUnknown { get; set; }

    [JsonPropertyName("lastupdate"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? LastUpdate { get; set; }
}