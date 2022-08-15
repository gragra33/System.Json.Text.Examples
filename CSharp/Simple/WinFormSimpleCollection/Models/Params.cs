// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WinFormSimpleCollection.Models;

public class Params
{
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}