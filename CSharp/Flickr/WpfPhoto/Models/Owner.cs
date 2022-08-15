// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;

namespace WpfPhoto.Models;

public class Owner
{
    [JsonPropertyName("nsid")]
    public string? NsId { get; set; }

    [JsonPropertyName("username")]
    public string? UserName { get; set; }

    [JsonPropertyName("realname")]
    public string? RealName { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("iconserver")]
    public int? IconServer { get; set; }

    [JsonPropertyName("iconfarm")]
    public int? IconFarm { get; set; }

    [JsonPropertyName("path_alias")]
    public string? PathAlias { get; set; }
}