// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class DraftsApiLimits
{
    [JsonPropertyName("/drafts/statuses/create")]
    public ApiRateLimit DraftsStatusesCreate { get; set; }

    [JsonPropertyName("/drafts/statuses/destroy")]
    public ApiRateLimit DraftsStatusesDestroy { get; set; }

    [JsonPropertyName("/drafts/statuses/ids")]
    public ApiRateLimit DraftsStatusesIds { get; set; }

    [JsonPropertyName("/drafts/statuses/list")]
    public ApiRateLimit DraftsStatusesList { get; set; }

    [JsonPropertyName("/drafts/statuses/show")]
    public ApiRateLimit DraftsStatusesShow { get; set; }

    [JsonPropertyName("/drafts/statuses/update")]
    public ApiRateLimit DraftsStatusesUpdate { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Drafts: StatusesCreate: ").AppendLine(DraftsStatusesCreate)
            .Append("> StatusesDestroy: ").AppendLine(DraftsStatusesDestroy)
            .Append("> StatusesIds: ").AppendLine(DraftsStatusesIds)
            .Append("> StatusesList: ").AppendLine(DraftsStatusesList)
            .Append("> StatusesShow: ").AppendLine(DraftsStatusesShow)
            .Append("> StatusesUpdate: ").AppendLine(DraftsStatusesUpdate);

        return sb.ToString();
    }

    public static implicit operator string(DraftsApiLimits o)
    {
        return o.ToString();
    }
}