// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfFileExplorer.Models;

public class Capabilities
{
    [JsonPropertyName("canEdit")]
    public bool? CanEdit { get; set; }

    [JsonPropertyName("canComment")]
    public bool? CanComment { get; set; }

    [JsonPropertyName("canShare")]
    public bool? CanShare { get; set; }

    [JsonPropertyName("canCopy")]
    public bool? CanCopy { get; set; }

    [JsonPropertyName("canReadRevisions")]
    public bool? CanReadRevisions { get; set; }
}