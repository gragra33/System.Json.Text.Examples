// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class ApplicationApiLimits
{
    [JsonPropertyName("/application/rate_limit_status")]
    public ApiRateLimit? ApplicationRateLimitStatus { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("Application: RateLimitStatus: ").AppendLine(ApplicationRateLimitStatus!)
            .ToString();

    public static implicit operator string(ApplicationApiLimits o)
        => o.ToString();
}