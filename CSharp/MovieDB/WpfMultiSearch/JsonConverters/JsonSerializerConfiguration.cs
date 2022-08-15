// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json;
using System.Text.Json.Serialization;

namespace WpfMultiSearch.JsonConverters;

public static class JsonSerializerConfiguration
{
    public static readonly JsonSerializerOptions Options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.Never
    };
}