// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class FriendsApiLimits
{
    [JsonPropertyName("/friends/following/ids")]
    public ApiRateLimit FriendsFollowingIds { get; set; }

    [JsonPropertyName("/friends/following/list")]
    public ApiRateLimit FriendsFollowingList { get; set; }

    [JsonPropertyName("/friends/ids")]
    public ApiRateLimit FriendsIds { get; set; }

    [JsonPropertyName("/friends/list")]
    public ApiRateLimit FriendsList { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Friends: FollowingIds: ").AppendLine(FriendsFollowingIds)
            .Append("> FollowingList: ").AppendLine(FriendsFollowingList)
            .Append("> Ids: ").AppendLine(FriendsIds)
            .Append("> List: ").AppendLine(FriendsList);

        return sb.ToString();
    }

    public static implicit operator string(FriendsApiLimits o)
    {
        return o.ToString();
    }
}