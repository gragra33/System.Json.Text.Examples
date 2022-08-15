// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class FollowersApiLimits
{
    [JsonPropertyName("/followers/ids")]
    public ApiRateLimit FollowersIds { get; set; }

    [JsonPropertyName("/followers/list")]
    public ApiRateLimit FollowersList { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Followers: Ids: ").AppendLine(FollowersIds)
            .Append("> List: ").AppendLine(FollowersList);

        return sb.ToString();
    }

    public static implicit operator string(FollowersApiLimits o)
    {
        return o.ToString();
    }
}