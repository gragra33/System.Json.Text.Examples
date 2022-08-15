// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace WpfPhoto.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]  
public enum GeoAccuracyType
{
    [EnumMember(Value = "0")]
    None,
    [EnumMember(Value = "1")]
    World,
    [EnumMember(Value = "2")]
    Level2,
    [EnumMember(Value = "3")]
    Country,
    [EnumMember(Value = "4")]
    Level4,
    [EnumMember(Value = "5")]
    Level5,
    [EnumMember(Value = "6")]
    Region,
    [EnumMember(Value = "7")]
    Level7,
    [EnumMember(Value = "8")]
    Level8,
    [EnumMember(Value = "9")]
    Level0,
    [EnumMember(Value = "10")]
    Level10,
    [EnumMember(Value = "11")]
    City,
    [EnumMember(Value = "12")]
    Level12,
    [EnumMember(Value = "13")]
    Level13,
    [EnumMember(Value = "14")]
    Level14,
    [EnumMember(Value = "15")]
    Level15,
    [EnumMember(Value = "16")]
    Street
}