// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using WpfFileExplorer.JsonConverters;

namespace WpfFileExplorer.Models;

public class User
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("photoLink"), JsonConverter(typeof(JsonGoogleUriContentConverter))]
    public Uri? PhotoLink { get; set; }

    [JsonPropertyName("me")]
    public bool? Me { get; set; }

    [JsonPropertyName("permissionId")]
    public string? PermissionId { get; set; }

    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }
}