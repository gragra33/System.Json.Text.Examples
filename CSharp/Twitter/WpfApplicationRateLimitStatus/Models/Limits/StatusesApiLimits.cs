// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class StatusesApiLimits
{
    [JsonPropertyName("/statuses/friends")]
    public ApiRateLimit StatusesFriends { get; set; }

    [JsonPropertyName("/statuses/home_timeline")]
    public ApiRateLimit StatusesHomeTimeline { get; set; }

    [JsonPropertyName("/statuses/lookup")]
    public ApiRateLimit StatusesLookup { get; set; }

    [JsonPropertyName("/statuses/mentions_timeline")]
    public ApiRateLimit StatusesMentionsTimeline { get; set; }

    [JsonPropertyName("/statuses/oembed")]
    public ApiRateLimit StatusesOembed { get; set; }

    [JsonPropertyName("/statuses/retweeters/ids")]
    public ApiRateLimit StatusesRetweetersIds { get; set; }

    [JsonPropertyName("/statuses/retweets/:id")]
    public ApiRateLimit StatusesRetweetsId { get; set; }

    [JsonPropertyName("/statuses/retweets_of_me")]
    public ApiRateLimit StatusesRetweetsOfMe { get; set; }

    [JsonPropertyName("/statuses/show/:id")]
    public ApiRateLimit StatusesShowId { get; set; }

    [JsonPropertyName("/statuses/user_timeline")]
    public ApiRateLimit StatusesUserTimeline { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Statuses: Friends: ").AppendLine(StatusesFriends)
            .Append("> HomeTimeline: ").AppendLine(StatusesHomeTimeline)
            .Append("> Lookup: ").AppendLine(StatusesLookup)
            .Append("> MentionsTimeline: ").AppendLine(StatusesMentionsTimeline)
            .Append("> Oembed: ").AppendLine(StatusesOembed)
            .Append("> RetweetersIds: ").AppendLine(StatusesRetweetersIds)
            .Append("> RetweetsId: ").AppendLine(StatusesRetweetsId)
            .Append("> RetweetsOfMe: ").AppendLine(StatusesRetweetsOfMe)
            .Append("> ShowId: ").AppendLine(StatusesShowId)
            .Append("> UserTimeline: ").AppendLine(StatusesUserTimeline);

        return sb.ToString();
    }

    public static implicit operator string(StatusesApiLimits o)
    {
        return o.ToString();
    }
}