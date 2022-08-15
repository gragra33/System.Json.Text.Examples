// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class FeedbackApiLimits
{
    [JsonPropertyName("/feedback/events")]
    public ApiRateLimit FeedbackEvents { get; set; }

    [JsonPropertyName("/feedback/show/:id")]
    public ApiRateLimit FeedbackShowId { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Feedback: Events: ").AppendLine(FeedbackEvents)
            .Append("> ShowId: ").AppendLine(FeedbackShowId);

        return sb.ToString();
    }

    public static implicit operator string(FeedbackApiLimits o)
    {
        return o.ToString();
    }
}