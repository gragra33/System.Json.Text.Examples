// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WpfUserAgent.Models;

public class UserAgentDataModel
{
    [JsonPropertyName("brands")]
    public List<BrandModel>? Brands { get; set; }

    [JsonPropertyName("mobile")]
    public bool? Mobile  { get; set; }

    [JsonPropertyName("platform")]
    public string? Platform  { get; set; }
}