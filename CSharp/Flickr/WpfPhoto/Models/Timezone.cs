// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Timezone
{
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("offset")]
    public string? Offset { get; set; }

    [JsonPropertyName("timezone_id")]
    public string? TimezoneId { get; set; }
}