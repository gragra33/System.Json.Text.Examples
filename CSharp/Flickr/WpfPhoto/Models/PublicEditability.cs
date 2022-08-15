// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class PublicEditability
{
    [JsonPropertyName("cancomment")]
    public bool? Cancomment { get; set; }

    [JsonPropertyName("canaddmeta")]
    public bool? Canaddmeta { get; set; }
}