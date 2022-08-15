// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Diagnostics;

namespace WpfPhoto.Models;

[DebuggerDisplay("{Label}")]
public class Size
{
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("url")]
    public Uri? Url { get; set; }

    [JsonPropertyName("media")]
    public string? Media { get; set; }
}