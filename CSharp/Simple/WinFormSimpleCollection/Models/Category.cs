// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WinFormSimpleCollection.Models;

public class Category
{
    [JsonPropertyName("category_id")]
    public int? CategoryId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("meta_title")]
    public string? MetaTitle { get; set; }

    [JsonPropertyName("meta_keywords")]
    public string? MetaKeywords { get; set; }

    [JsonPropertyName("meta_description")]
    public string? MetaDescription { get; set; }

    [JsonPropertyName("page_description")]
    public string? PageDescription { get; set; }

    [JsonPropertyName("page_title")]
    public string? PageTitle { get; set; }

    [JsonPropertyName("category_name")]
    public string? CategoryName { get; set; }

    [JsonPropertyName("short_name")]
    public string? ShortName { get; set; }

    [JsonPropertyName("long_name")]
    public string? LongName { get; set; }

    [JsonPropertyName("num_children")]
    public int? NumChildren { get; set; }

    public string FormattedId
        => CategoryId < 1
            ? "[UNKNOWN]"
            : $"ID# {CategoryId}";
}