// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class HelpApiLimits
{
    [JsonPropertyName("/help/configuration")]
    public ApiRateLimit HelpConfiguration { get; set; }

    [JsonPropertyName("/help/languages")]
    public ApiRateLimit HelpLanguages { get; set; }

    [JsonPropertyName("/help/privacy")]
    public ApiRateLimit HelpPrivacy { get; set; }

    [JsonPropertyName("/help/settings")]
    public ApiRateLimit HelpSettings { get; set; }

    [JsonPropertyName("/help/tos")]
    public ApiRateLimit HelpTos { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Help: Configuration: ").AppendLine(HelpConfiguration)
            .Append("> Languages: ").AppendLine(HelpLanguages)
            .Append("> Privacy: ").AppendLine(HelpPrivacy)
            .Append("> Settings: ").AppendLine(HelpSettings)
            .Append("> Tos: ").AppendLine(HelpTos);

        return sb.ToString();
    }

    public static implicit operator string(HelpApiLimits o)
    {
        return o.ToString();
    }
}