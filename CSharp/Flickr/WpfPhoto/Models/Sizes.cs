// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WpfPhoto.Models;

public class Sizes
{
    [JsonPropertyName("canblog")]
    public bool? CanBlog { get; set; }

    [JsonPropertyName("canprint")]
    public bool? CanPrint { get; set; }

    [JsonPropertyName("candownload")]
    public bool? CanDownload { get; set; }

    [JsonPropertyName("size")]
    public IList<Size>? SizeList { get; set; }
}