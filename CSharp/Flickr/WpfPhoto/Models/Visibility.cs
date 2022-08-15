// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Visibility
{
    [JsonPropertyName("ispublic")]
    public bool? IsPublic { get; set; }

    [JsonPropertyName("isfriend")]
    public bool? IsFriend { get; set; }

    [JsonPropertyName("isfamily")]
    public bool? IsFamily { get; set; }
}