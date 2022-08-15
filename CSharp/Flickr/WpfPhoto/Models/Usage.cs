// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Usage
{
    [JsonPropertyName("candownload")]
    public bool? CanDownload { get; set; }

    [JsonPropertyName("canblog")]
    public bool? CanBlog { get; set; }

    [JsonPropertyName("canprint")]
    public bool? CanPrint { get; set; }

    [JsonPropertyName("canshare")]
    public bool? CanShare { get; set; }
}