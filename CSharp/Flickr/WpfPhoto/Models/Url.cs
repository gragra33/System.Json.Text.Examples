// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;

namespace WpfPhoto.Models;

public class Url
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("_content")]
    public Uri? Uri { get; set; }
}