// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class SearchApiLimits
{
    [JsonPropertyName("/search/tweets")]
    public ApiRateLimit SearchTweets { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Search: Tweets: ").AppendLine(SearchTweets);

        return sb.ToString();
    }

    public static implicit operator string(SearchApiLimits o)
    {
        return o.ToString();
    }
}