// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Location
{
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("accuracy")]
    public GeoAccuracyType? Accuracy { get; set; }

    [JsonPropertyName("context")]
    public GeoContextType? Context { get; set; }

    [JsonPropertyName("locality")]
    public Locality? Locality { get; set; }

    [JsonPropertyName("county")]
    public County? County { get; set; }

    [JsonPropertyName("region")]
    public Region? Region { get; set; }

    [JsonPropertyName("country")]
    public Country? Country { get; set; }

    [JsonPropertyName("place_id")]
    public string? PlaceId { get; set; }

    [JsonPropertyName("woeid")]
    public string? WoeId { get; set; }
}