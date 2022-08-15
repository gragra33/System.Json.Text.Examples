// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class MutesApiLimits
{
    [JsonPropertyName("/mutes/users/ids")]
    public ApiRateLimit MutesUsersIds { get; set; }

    [JsonPropertyName("/mutes/users/list")]
    public ApiRateLimit MutesUsersList { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Mutes: UsersIds: ").AppendLine(MutesUsersIds)
            .Append("> UsersList: ").AppendLine(MutesUsersList);

        return sb.ToString();
    }

    public static implicit operator string(MutesApiLimits o)
    {
        return o.ToString();
    }
}