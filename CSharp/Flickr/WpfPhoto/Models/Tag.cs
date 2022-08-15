// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Diagnostics;
using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

[DebuggerDisplay("{Raw}")]
public class Tag
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("authorname")]
    public string? AuthorName { get; set; }

    [JsonPropertyName("_content")]
    public string? Name { get; set; }

    [JsonPropertyName("machine_tag")]
    public bool? MachineTag { get; set; }

    [JsonPropertyName("raw")]
    public string? Raw { get; set; }
}