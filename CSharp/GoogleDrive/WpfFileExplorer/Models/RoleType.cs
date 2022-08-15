// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace WpfFileExplorer.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RoleType
{
    [EnumMember(Value = "owner")]
    Owner,
    [EnumMember(Value = "writer")]
    Writer,
    [EnumMember(Value = "commenter")]
    Commenter,
    [EnumMember(Value = "reader")]
    Reader
}