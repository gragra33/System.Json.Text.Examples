// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class FriendshipsApiLimits
{
    [JsonPropertyName("/friendships/incoming")]
    public ApiRateLimit FriendshipsIncoming { get; set; }

    [JsonPropertyName("/friendships/list")]
    public ApiRateLimit FriendshipsList { get; set; }

    [JsonPropertyName("/friendships/lookup")]
    public ApiRateLimit FriendshipsLookup { get; set; }

    [JsonPropertyName("/friendships/no_retweets/ids")]
    public ApiRateLimit FriendshipsNoRetweetsIds { get; set; }

    [JsonPropertyName("/friendships/outgoing")]
    public ApiRateLimit FriendshipsOutgoing { get; set; }

    [JsonPropertyName("/friendships/show")]
    public ApiRateLimit FriendshipsShow { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Friendships: Incoming: ").AppendLine(FriendshipsIncoming)
            .Append("> List: ").AppendLine(FriendshipsList)
            .Append("> Lookup: ").AppendLine(FriendshipsLookup)
            .Append("> NoRetweetsIds: ").AppendLine(FriendshipsNoRetweetsIds)
            .Append("> Outgoing: ").AppendLine(FriendshipsOutgoing)
            .Append("> Show: ").AppendLine(FriendshipsShow);

        return sb.ToString();
    }

    public static implicit operator string(FriendshipsApiLimits o)
    {
        return o.ToString();
    }
}