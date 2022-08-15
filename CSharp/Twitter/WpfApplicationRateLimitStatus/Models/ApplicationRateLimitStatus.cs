// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class ApplicationRateLimitStatus
{
    [JsonPropertyName("rate_limit_context")]
    public RateLimitContext RateLimitContext { get; set; }

    [JsonPropertyName("resources")]
    public Resources Resources { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("RateLimitContext: ")
            .AppendLine(RateLimitContext.AccessToken)
            .AppendLine(Resources);

        return sb.ToString();
    }

    public static implicit operator string(ApplicationRateLimitStatus o)
    {
        return o.ToString();
    }
}