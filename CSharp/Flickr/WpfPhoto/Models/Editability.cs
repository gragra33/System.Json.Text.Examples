// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Editability
{
    [JsonPropertyName("cancomment")]
    public bool? CanComment { get; set; }

    [JsonPropertyName("canaddmeta")]
    public bool? CanAddMeta { get; set; }
}