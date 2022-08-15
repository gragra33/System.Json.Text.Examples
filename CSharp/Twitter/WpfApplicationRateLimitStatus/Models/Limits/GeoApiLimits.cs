// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class GeoApiLimits
{
    [JsonPropertyName("/geo/id/:place_id")]
    public ApiRateLimit GeoIdPlaceId { get; set; }

    [JsonPropertyName("/geo/reverse_geocode")]
    public ApiRateLimit GeoReverseGeocode { get; set; }

    [JsonPropertyName("/geo/search")]
    public ApiRateLimit GeoSearch { get; set; }

    [JsonPropertyName("/geo/similar_places")]
    public ApiRateLimit GeoSimilarPlaces { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Geo: IdPlaceId: ").AppendLine(GeoIdPlaceId)
            .Append("> ReverseGeocode: ").AppendLine(GeoReverseGeocode)
            .Append("> Search: ").AppendLine(GeoSearch)
            .Append("> SimilarPlaces: ").AppendLine(GeoSimilarPlaces);

        return sb.ToString();
    }

    public static implicit operator string(GeoApiLimits o)
    {
        return o.ToString();
    }
}