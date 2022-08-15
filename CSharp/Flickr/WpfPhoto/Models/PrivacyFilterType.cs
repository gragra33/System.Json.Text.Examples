// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace WpfPhoto.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]  
public enum PrivacyFilterType
{
    [EnumMember(Value = "0")]
    None,
    [EnumMember(Value = "1")]
    PublicPhotos,
    [EnumMember(Value = "2")]
    PrivateVisibleToFriends,
    [EnumMember(Value = "3")]
    PrivateVisibleToFamily,
    [EnumMember(Value = "4")]
    PrivateVisibleToFriendsFamily,
    [EnumMember(Value = "5")]
    CompletelyPrivate
}