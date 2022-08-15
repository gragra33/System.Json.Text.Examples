// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class CustomProfilesApiLimits
{
    [JsonPropertyName("/custom_profiles/list")]
    public ApiRateLimit CustomProfilesList { get; set; }

    [JsonPropertyName("/custom_profiles/show")]
    public ApiRateLimit CustomProfilesShow { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("CustomProfiles: List: ").AppendLine(CustomProfilesList)
            .Append("> Show: ").AppendLine(CustomProfilesShow);

        return sb.ToString();
    }

    public static implicit operator string(CustomProfilesApiLimits o)
    {
        return o.ToString();
    }
}