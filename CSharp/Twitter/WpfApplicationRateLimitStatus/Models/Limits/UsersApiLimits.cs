// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class UsersApiLimits
{

    [JsonPropertyName("/users/derived_info")]
    public ApiRateLimit UsersDerivedInfo { get; set; }

    [JsonPropertyName("/users/lookup")]
    public ApiRateLimit UsersLookup { get; set; }

    [JsonPropertyName("/users/profile_banner")]
    public ApiRateLimit UsersProfileBanner { get; set; }

    [JsonPropertyName("/users/report_spam")]
    public ApiRateLimit UsersReportSpam { get; set; }

    [JsonPropertyName("/users/search")]
    public ApiRateLimit UsersSearch { get; set; }

    [JsonPropertyName("/users/show/:id")]
    public ApiRateLimit UsersShowId { get; set; }

    [JsonPropertyName("/users/suggestions")]
    public ApiRateLimit UsersSuggestions { get; set; }

    [JsonPropertyName("/users/suggestions/:slug")]
    public ApiRateLimit UsersSuggestionsSlug { get; set; }

    [JsonPropertyName("/users/suggestions/:slug/members")]
    public ApiRateLimit UsersSuggestionsSlugMembers { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Users: UsersDerivedInfo: ").AppendLine(UsersDerivedInfo)
            .Append("> UsersLookup: ").AppendLine(UsersLookup)
            .Append("> UsersProfileBanner: ").AppendLine(UsersProfileBanner)
            .Append("> UsersReportSpam: ").AppendLine(UsersReportSpam)
            .Append("> UsersSearch: ").AppendLine(UsersSearch)
            .Append("> UsersShowId: ").AppendLine(UsersShowId)
            .Append("> UsersSuggestions: ").AppendLine(UsersSuggestions)
            .Append("> UsersSuggestionsSlug: ").AppendLine(UsersSuggestionsSlug)
            .Append("> UsersSuggestionsSlugMembers: ").AppendLine(UsersSuggestionsSlugMembers);

        return sb.ToString();
    }

    public static implicit operator string(UsersApiLimits o)
    {
        return o.ToString();
    }
}