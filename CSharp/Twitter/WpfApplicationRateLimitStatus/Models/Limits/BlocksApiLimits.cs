// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class BlocksApiLimits
{
    [JsonPropertyName("/blocks/list")]
    public ApiRateLimit? BlocksList { get; set; }

    [JsonPropertyName("/blocks/ids")]
    public ApiRateLimit? BlocksIds { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("Blocks: List: ").AppendLine(BlocksList!)
            .Append("> Ids: ").AppendLine(BlocksIds!)
            .ToString();

    public static implicit operator string(BlocksApiLimits o)
        => o.ToString();
}