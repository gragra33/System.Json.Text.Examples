// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class TrendsApiLimits
{
    [JsonPropertyName("/trends/available")]
    public ApiRateLimit TrendsAvailable { get; set; }

    [JsonPropertyName("/trends/closest")]
    public ApiRateLimit TrendsClosest { get; set; }

    [JsonPropertyName("/trends/place")]
    public ApiRateLimit TrendsPlace { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Trends: Available: ").AppendLine(TrendsAvailable)
            .Append("> Closest: ").AppendLine(TrendsClosest)
            .Append("> Place: ").AppendLine(TrendsPlace);

        return sb.ToString();
    }

    public static implicit operator string(TrendsApiLimits o)
    {
        return o.ToString();
    }
}