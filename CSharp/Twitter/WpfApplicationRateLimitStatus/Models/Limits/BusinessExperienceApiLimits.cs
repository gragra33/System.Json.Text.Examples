// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class BusinessExperienceApiLimits
{
    [JsonPropertyName("/business_experience/dashboard_features")]
    public ApiRateLimit? BusinessExperienceDashboardFeatures { get; set; }

    [JsonPropertyName("/business_experience/dashboard_settings/destroy")]
    public ApiRateLimit? BusinessExperienceDashboardSettingsDestroy { get; set; }

    [JsonPropertyName("/business_experience/dashboard_settings/show")]
    public ApiRateLimit? BusinessExperienceDashboardSettingsShow { get; set; }

    [JsonPropertyName("/business_experience/dashboard_settings/update")]
    public ApiRateLimit? BusinessExperienceDashboardSettingsUpdate { get; set; }

    [JsonPropertyName("/business_experience/keywords")]
    public ApiRateLimit? BusinessExperienceKeywords { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("BusinessExperience: DashboardFeatures: ").AppendLine(BusinessExperienceDashboardFeatures!)
            .Append("> DashboardSettingsDestroy: ").AppendLine(BusinessExperienceDashboardSettingsDestroy!)
            .Append("> DashboardSettingsShow: ").AppendLine(BusinessExperienceDashboardSettingsShow!)
            .Append("> DashboardSettingsUpdate: ").AppendLine(BusinessExperienceDashboardSettingsUpdate!)
            .Append("> Keywords: ").AppendLine(BusinessExperienceKeywords!)
            .ToString();

    public static implicit operator string(BusinessExperienceApiLimits o)
        => o.ToString();
}