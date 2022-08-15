// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class SavedSearchesApiLimits
{
    [JsonPropertyName("/saved_searches/destroy/:id")]
    public ApiRateLimit SavedSearchesDestroyId { get; set; }

    [JsonPropertyName("/saved_searches/list")]
    public ApiRateLimit SavedSearchesList { get; set; }

    [JsonPropertyName("/saved_searches/show/:id")]
    public ApiRateLimit SavedSearchesShowId { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("SavedSearches: DestroyId: ").AppendLine(SavedSearchesDestroyId)
            .Append("> List: ").AppendLine(SavedSearchesList)
            .Append("> ShowId: ").AppendLine(SavedSearchesShowId);

        return sb.ToString();
    }

    public static implicit operator string(SavedSearchesApiLimits o)
    {
        return o.ToString();
    }
}