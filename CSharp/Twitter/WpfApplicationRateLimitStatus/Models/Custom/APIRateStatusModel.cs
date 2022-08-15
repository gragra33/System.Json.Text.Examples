// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Collections.ObjectModel;
using WpfApplicationRateLimitStatus.JsonConverters;

namespace WpfApplicationRateLimitStatus.Models;

public class APIRateStatusModel
{
    [JsonPropertyName("resources"), JsonConverter(typeof(JsonApiRateLimitsConverter))]
    public ObservableCollection<RateCategoryModel>? Resources { get; set; }
}