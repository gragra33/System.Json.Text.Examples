// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class CollectionsApiLimits
{
    [JsonPropertyName("/collections/entries")]
    public ApiRateLimit? CollectionsEntries { get; set; }

    [JsonPropertyName("/collections/list")]
    public ApiRateLimit? CollectionsList { get; set; }

    [JsonPropertyName("/collections/show")]
    public ApiRateLimit? CollectionsShow { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("Collections: Entries: ").AppendLine(CollectionsEntries!)
            .Append("> List: ").AppendLine(CollectionsList!)
            .Append("> Show: ").AppendLine(CollectionsShow!)
            .ToString();

    public static implicit operator string(CollectionsApiLimits o)
        => o.ToString();
}