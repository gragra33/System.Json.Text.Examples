// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using WpfPhoto.JsonConverters;

namespace WpfPhoto.Models;

public class Person
{
    [JsonPropertyName("id")]
    private string Id { set => nsid = value; }
    private string? nsid;

    [JsonPropertyName("nsid")]
    public string NsId { get => nsid ?? ""; set => nsid = value; }

    [JsonPropertyName("ispro")]
    public bool? IsPro { get; set; }

    [JsonPropertyName("can_buy_pro")]
    public bool? CanBuyPro { get; set; }

    [JsonPropertyName("iconserver")]
    public int? IconServer { get; set; }

    [JsonPropertyName("iconfarm")]
    public int? IconFarm { get; set; }

    [JsonPropertyName("path_alias")]
    public string? PathAlias { get; set; }

    [JsonPropertyName("has_stats")]
    public bool? HasStats { get; set; }

    [JsonPropertyName("username"), JsonConverter(typeof(JsonFlickrContentConverter<string>))]
    public string? UserName { get; set; }

    [JsonPropertyName("realname"), JsonConverter(typeof(JsonFlickrContentConverter<string>))]
    public string? RealName { get; set; }

    [JsonPropertyName("location"), JsonConverter(typeof(JsonFlickrContentConverter<string>))]
    public string? Location { get; set; }

    [JsonPropertyName("timezone")]
    public Timezone? Timezone { get; set; }

    [JsonPropertyName("description"), JsonConverter(typeof(JsonFlickrContentConverter<string>))]
    public string? Description { get; set; }

    [JsonPropertyName("photosurl"), JsonConverter(typeof(JsonFlickrContentConverter<Uri>))]
    public Uri? PhotosUrl { get; set; }

    [JsonPropertyName("profileurl"), JsonConverter(typeof(JsonFlickrContentConverter<Uri>))]
    public Uri? ProfileUrl { get; set; }

    [JsonPropertyName("mobileurl"), JsonConverter(typeof(JsonFlickrContentConverter<Uri>))]
    public Uri? MobileUrl { get; set; }

    [JsonPropertyName("photos")]
    public PhotoInfo? PhotoInfo { get; set; }

    [JsonPropertyName("content_type")]
    public ContentType? ContentType { get; set; }

    [JsonPropertyName("geoperms")]
    public GeoPermissionType? GeoPermission { get; set; }

    [JsonPropertyName("importgeoexif")]
    public bool? ImportGeoExif { get; set; }

    [JsonPropertyName("hidden")]
    public HiddenFromSearchType? HiddenFromSearch { get; set; }

    [JsonPropertyName("privacy")]
    public PrivacyFilterType? PrivacyFilter { get; set; }

    [JsonPropertyName("safety_level")]
    public SafetyLevelType? SafetyLevel { get; set; }

    [JsonPropertyName("haspeople")]
    public bool? HasPeople { get; set; }

    [JsonPropertyName("contact")]
    public bool? IsContact { get; set; }

    [JsonPropertyName("family")]
    public bool? IsFamily { get; set; }

    [JsonPropertyName("friend")]
    public bool? IsFriend { get; set; }
}