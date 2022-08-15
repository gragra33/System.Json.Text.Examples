// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class LiveVideoStreamApiLimits
{
    [JsonPropertyName("/live_video_stream/status/:id")]
    public ApiRateLimit LiveVideoStreamStatusId { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("LiveVideoStream: StatusId: ").AppendLine(LiveVideoStreamStatusId);

        return sb.ToString();
    }

    public static implicit operator string(LiveVideoStreamApiLimits o)
    {
        return o.ToString();
    }
}