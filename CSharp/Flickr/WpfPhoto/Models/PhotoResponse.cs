// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class PhotoResponse : ResponseBase
{
    [JsonPropertyName("photo")]
    public Photo? Photo { get; set; }
}