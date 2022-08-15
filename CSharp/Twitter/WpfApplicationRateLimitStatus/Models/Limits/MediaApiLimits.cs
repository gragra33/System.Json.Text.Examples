// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class MediaApiLimits
{
    [JsonPropertyName("/media/upload")]
    public ApiRateLimit MediaUpload { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Media: Upload: ").AppendLine(MediaUpload);

        return sb.ToString();
    }

    public static implicit operator string(MediaApiLimits o)
    {
        return o.ToString();
    }
}