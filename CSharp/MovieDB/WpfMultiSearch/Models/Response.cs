// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using System.Text.Json.Serialization;
using WpfMultiSearch.JsonConverters;

namespace WpfMultiSearch.Models;

public class Response
{

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("results"), JsonConverter(typeof(JsonDataTypeConverter))]
    public List<IDataType>? Results { get; set; }

    [JsonPropertyName("total_pages")]
    public int? TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int? TotalResults { get; set; }
}