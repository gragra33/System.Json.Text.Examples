// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfFileExplorer.Models;

public class ImageMediaMetadata
{
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("rotation")]
    public int? Rotation { get; set; }

    [JsonPropertyName("location")]
    public Location? Location { get; set; }

    [JsonPropertyName("altitude")]
    public double? Altitude { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("cameraMake")]
    public string? CameraMake { get; set; }

    [JsonPropertyName("cameraModel")]
    public string? CameraModel { get; set; }

    [JsonPropertyName("exposureTime")]
    public double? ExposureTime { get; set; }

    [JsonPropertyName("aperture")]
    public double? Aperture { get; set; }

    [JsonPropertyName("flashUsed")]
    public bool? FlashUsed { get; set; }

    [JsonPropertyName("focalLength")]
    public double? FocalLength { get; set; }

    [JsonPropertyName("isoSpeed")]
    public int? IsoSpeed { get; set; }

    [JsonPropertyName("meteringMode")]
    public string? MeteringMode { get; set; }

    [JsonPropertyName("sensor")]
    public string? Sensor { get; set; }

    [JsonPropertyName("exposureMode")]
    public string? ExposureMode { get; set; }

    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("whiteBalance")]
    public string? WhiteBalance { get; set; }

    [JsonPropertyName("exposureBias")]
    public double? ExposureBias { get; set; }

    [JsonPropertyName("maxApertureValue")]
    public double? MaxApertureValue { get; set; }

    [JsonPropertyName("subjectDistance")]
    public int? SubjectDistance { get; set; }

    [JsonPropertyName("lens")]
    public string? Lens { get; set; }
}