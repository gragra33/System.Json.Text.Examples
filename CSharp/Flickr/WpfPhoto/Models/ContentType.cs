// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]  
public enum ContentType
{
    [EnumMember(Value = "0")]
    None,
    [EnumMember(Value = "1")]
    Photo,
    [EnumMember(Value = "2")]
    Screenshot,
    [EnumMember(Value = "3")]
    Other,
    [EnumMember(Value = "4")]
    PhotoAndScreenshot,
    [EnumMember(Value = "5")]
    ScreenshotAndOther,
    [EnumMember(Value = "6")]
    PhotoOther,
    [EnumMember(Value = "7")]
    All
}