// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using WpfFileExplorer.Contracts;
using WpfFileExplorer.JsonConverters;

namespace WpfFileExplorer.Models;

[DebuggerDisplay("[File] {Name} ({Kind} | {MimeType})")]
public class File : IResourceKind
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("starred")]
    public bool? Starred { get; set; }

    [JsonPropertyName("trashed")]
    public bool? Trashed { get; set; }

    [JsonPropertyName("explicitlyTrashed")]
    public bool? ExplicitlyTrashed { get; set; }

    [JsonPropertyName("parents")]
    public IList<string>? Parents { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("appProperties")]
    public IDictionary<string, string>? AppProperties { get; set; }

    [JsonPropertyName("spaces")]
    public IList<string>? Spaces { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("webContentLink"), JsonConverter(typeof(JsonGoogleUriContentConverter))]
    public Uri? WebContentLink { get; set; }

    [JsonPropertyName("webViewLink"), JsonConverter(typeof(JsonGoogleUriContentConverter))]
    public Uri? WebViewLink { get; set; }

    [JsonPropertyName("iconLink"), JsonConverter(typeof(JsonGoogleUriContentConverter))]
    public Uri? IconLink { get; set; }

    [JsonPropertyName("thumbnailLink"), JsonConverter(typeof(JsonGoogleUriContentConverter))]
    public Uri? ThumbnailLink { get; set; }

    [JsonPropertyName("viewedByMe")]
    public bool? ViewedByMe { get; set; }

    [JsonPropertyName("viewedByMeTime")]
    public DateTime? ViewedByMeTime { get; set; }

    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    [JsonPropertyName("modifiedTime")]
    public DateTime? ModifiedTime { get; set; }

    [JsonPropertyName("modifiedByMeTime")]
    public DateTime? ModifiedByMeTime { get; set; }

    [JsonPropertyName("owners")]
    public IList<User>? Owners { get; set; }

    [JsonPropertyName("lastModifyingUser")]
    public User? LastModifyingUser { get; set; }

    [JsonPropertyName("shared")]
    public bool? Shared { get; set; }

    [JsonPropertyName("sharedWithMeTime")]
    public DateTime? SharedWithMeTime { get; set; }

    [JsonPropertyName("sharingUser")]
    public User? SharingUser { get; set; }

    [JsonPropertyName("ownedByMe")]
    public bool? OwnedByMe { get; set; }

    [JsonPropertyName("capabilities")]
    public Capabilities? Capabilities { get; set; }

    [JsonPropertyName("viewersCanCopyContent")]
    public bool? ViewersCanCopyContent { get; set; }

    [JsonPropertyName("writersCanShare")]
    public bool? WritersCanShare { get; set; }

    [JsonPropertyName("permissions")]
    public IList<Permission>? Permissions { get; set; }

    [JsonPropertyName("originalFilename")]
    public string? OriginalFilename { get; set; }

    [JsonPropertyName("fullFileExtension")]
    public string? FullFileExtension { get; set; }

    [JsonPropertyName("fileExtension")]
    public string? FileExtension { get; set; }

    [JsonPropertyName("md5Checksum")]
    public string? Md5Checksum { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("folderColorRgb")]
    public string? FolderColorRgb { get; set; }

    [JsonPropertyName("quotaBytesUsed")]
    public long? QuotaBytesUsed { get; set; }

    [JsonPropertyName("imageMediaMetadata")]
    public ImageMediaMetadata? ImageMediaMetadata { get; set; }

    [JsonPropertyName("headRevisionId")]
    public string? HeadRevisionId { get; set; }

    [JsonPropertyName("videoMediaMetadata")]
    public VideoMediaMetadata? VideoMediaMetadata { get; set; }

    [JsonPropertyName("isAppAuthorized")]
    public bool? IsAppAuthorized { get; set; }
}