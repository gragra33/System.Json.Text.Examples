// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class TweetPromptsApiLimits
{
    [JsonPropertyName("/tweet_prompts/report_interaction")]
    public ApiRateLimit TweetPromptsReportInteraction { get; set; }

    [JsonPropertyName("/tweet_prompts/show")]
    public ApiRateLimit TweetPromptsShow { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("TweetPrompts: ReportInteraction: ").AppendLine(TweetPromptsReportInteraction)
            .Append("> Show: ").AppendLine(TweetPromptsShow);

        return sb.ToString();
    }

    public static implicit operator string(TweetPromptsApiLimits o)
    {
        return o.ToString();
    }
}