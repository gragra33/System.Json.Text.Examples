// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class DeviceApiLimits
{
    [JsonPropertyName("/device/token")]
    public ApiRateLimit DeviceToken { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Device: Token: ").AppendLine(DeviceToken);

        return sb.ToString();
    }

    public static implicit operator string(DeviceApiLimits o)
    {
        return o.ToString();
    }
}