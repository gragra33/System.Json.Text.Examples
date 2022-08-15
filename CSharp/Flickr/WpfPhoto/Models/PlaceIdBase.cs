// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public abstract class PlaceIdBase
{
    [JsonPropertyName("place_id")]
    public string? PlaceId { get; set; }

    [JsonPropertyName("woeid")]
    public string? WoeId { get; set; }

    [JsonPropertyName("_content")]
    public string? Name { get; set; }
}