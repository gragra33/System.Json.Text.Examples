// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WinFormSimpleCollection.Models;

public class Pagination
{
    [JsonPropertyName("effective_limit")]
    public int? EffectiveLimit { get; set; }

    [JsonPropertyName("effective_offset")]
    public int? EffectiveOffset { get; set; }

    [JsonPropertyName("effective_page")]
    public int? EffectivePage { get; set; }

    [JsonPropertyName("next_offset")]
    public int? NextOffset { get; set; }

    [JsonPropertyName("next_page")]
    public int? NextPage { get; set; }
}