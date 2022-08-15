// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace WpfPhoto.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]  
public enum SafetyLevelType
{
    [EnumMember(Value = "0")]
    None,
    [EnumMember(Value = "1")]
    Safe,
    [EnumMember(Value = "2")]
    Moderate,
    [EnumMember(Value = "3")]
    Restricted
}