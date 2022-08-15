// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfApplicationRateLimitStatus.Models;

public class RateLimitContext
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}