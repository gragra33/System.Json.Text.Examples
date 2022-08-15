// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace WpfPhoto.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]  
public enum GeoContextType
{
    [EnumMember(Value = "0")]
    NotDefined = 0,
    [EnumMember(Value = "1")]
    Indoors = 1,
    [EnumMember(Value = "2")]
    Outdoors = 2
}