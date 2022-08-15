// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class ListsApiLimits
{
    [JsonPropertyName("/lists/list")]
    public ApiRateLimit ListsList { get; set; }

    [JsonPropertyName("/lists/members")]
    public ApiRateLimit ListsMembers { get; set; }

    [JsonPropertyName("/lists/memberships")]
    public ApiRateLimit ListsMemberships { get; set; }

    [JsonPropertyName("/lists/members/show")]
    public ApiRateLimit ListsMembersShow { get; set; }

    [JsonPropertyName("/lists/ownerships")]
    public ApiRateLimit ListsOwnerships { get; set; }

    [JsonPropertyName("/lists/show")]
    public ApiRateLimit ListsShow { get; set; }

    [JsonPropertyName("/lists/statuses")]
    public ApiRateLimit ListsStatuses { get; set; }

    [JsonPropertyName("/lists/subscribers")]
    public ApiRateLimit ListsSubscribers { get; set; }

    [JsonPropertyName("/lists/subscribers/show")]
    public ApiRateLimit ListsSubscribersShow { get; set; }

    [JsonPropertyName("/lists/subscriptions")]
    public ApiRateLimit ListsSubscriptions { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Lists: List: ").AppendLine(ListsList)
            .Append("> Members: ").AppendLine(ListsMembers)
            .Append("> Memberships: ").AppendLine(ListsMemberships)
            .Append("> MembersShow: ").AppendLine(ListsMembersShow)
            .Append("> Ownerships: ").AppendLine(ListsOwnerships)
            .Append("> Show: ").AppendLine(ListsShow)
            .Append("> Statuses: ").AppendLine(ListsStatuses)
            .Append("> Subscribers: ").AppendLine(ListsSubscribers)
            .Append("> SubscribersShow: ").AppendLine(ListsSubscribersShow)
            .Append("> Subscriptions: ").AppendLine(ListsSubscriptions);

        return sb.ToString();
    }

    public static implicit operator string(ListsApiLimits o)
    {
        return o.ToString();
    }
}