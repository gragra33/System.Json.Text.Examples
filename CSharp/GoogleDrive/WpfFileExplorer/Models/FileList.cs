// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Collections.Generic;
using WpfFileExplorer.Contracts;
using WpfFileExplorer.JsonConverters;

namespace WpfFileExplorer.Models;

public class FileList
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("nextPageToken")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("files"), JsonConverter(typeof(JsonDataTypeConverter))]
    public List<File>? Files { get; set; }
}