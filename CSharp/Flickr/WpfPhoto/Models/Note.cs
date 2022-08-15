// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Note
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("photo_id")]
    public string? PhotoId { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("authorname")]
    public string? AuthorName { get; set; }

    [JsonPropertyName("authorrealname")]
    public string? AuthorRealName { get; set; }

    [JsonPropertyName("authorispro")]
    public bool? AuthorIsPro { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }

    [JsonPropertyName("w")]
    public int? W { get; set; }

    [JsonPropertyName("h")]
    public int? H { get; set; }

    [JsonPropertyName("_content")]
    public string? Message { get; set; }
}