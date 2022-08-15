// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using System.Diagnostics;
using Support.CSharp.Json.Converters;
using Support.CSharp.Observable;

namespace WpfApplicationRateLimitStatus.Models;

[DebuggerDisplay("Limit: {Limit} / Remaining:{Remaining} / {Reset}")]
public class ApiRateLimitModel : ObservableObject
{
    private int? limit;
    private int? remaining;
    private DateTime? reset;

    [JsonPropertyName("limit")]
    public int? Limit
    {
        get => limit;
        set => Set(ref limit, value);
    }

    [JsonPropertyName("remaining")]
    public int? Remaining
    {
        get => remaining;
        set => Set(ref remaining, value);
    }

    [JsonPropertyName("reset"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? Reset
    {
        get => reset;
        set => Set(ref reset, value);
    }
}