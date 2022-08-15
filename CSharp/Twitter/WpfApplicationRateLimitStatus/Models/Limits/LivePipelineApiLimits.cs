// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class LivePipelineApiLimits
{
    [JsonPropertyName("/live_pipeline/events")]
    public ApiRateLimit LivePipelineEvents { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("LivePipeline: Events: ").AppendLine(LivePipelineEvents);

        return sb.ToString();
    }

    public static implicit operator string(LivePipelineApiLimits o)
    {
        return o.ToString();
    }
}