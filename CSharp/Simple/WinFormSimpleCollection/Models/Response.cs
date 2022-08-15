// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WinFormSimpleCollection.Models;

public class Response<TModel> where TModel : class
{
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("results")]
    public IList<TModel>? Results { get; set; }

    [JsonPropertyName("params")]
    public Params? Params { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}