// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace WpfPhoto.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]  
public enum GeoPermissionType
{
    [EnumMember(Value = "0")]
    None,
    [EnumMember(Value = "1")]
    Public,
    [EnumMember(Value = "2")]
    ContactsOnly,
    [EnumMember(Value = "3")]
    FriendsAndFamilyOnly,
    [EnumMember(Value = "4")]
    FriendsOnly,
    [EnumMember(Value = "5")]
    FamilyOnly,
    [EnumMember(Value = "6")]
    Private
}