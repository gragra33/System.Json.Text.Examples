// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfMultiSearch.Models;

public abstract class RecordBase : IDataType
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("media_type")]
    public string? MediaType { get; set; }

    [JsonPropertyName("popularity")]
    public double? Popularity { get; set; }
}