// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class MomentsApiLimits
{
    [JsonPropertyName("/moments/permissions")]
    public ApiRateLimit MomentsPermissions { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Moments: Permissions: ").AppendLine(MomentsPermissions);

        return sb.ToString();
    }

    public static implicit operator string(MomentsApiLimits o)
    {
        return o.ToString();
    }
}