// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System;
using Support.CSharp.Json.Converters;

namespace WpfApplicationRateLimitStatus.Models;

public class ApiRateLimit
{
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("remaining")]
    public int? Remaining { get; set; }

    [JsonPropertyName("reset"), JsonConverter(typeof(JsonUnixDateConverter))]
    public DateTime? Reset { get; set; }

    public override string ToString()
    {
        string msg = Remaining.HasValue && Limit.HasValue ? $"{Remaining.Value,4:N0} of {Limit.Value,4:N0} remaining." : "-- no data --";
 
        if (Reset.HasValue)
        {
            DateTime utcDateTime = Reset.Value;
            TimeSpan timeframe = utcDateTime - DateTime.UtcNow;
            
            return $"{msg} Reset in {timeframe.Minutes,4}m {timeframe.Seconds,2}s @ {utcDateTime.ToLocalTime()} ({utcDateTime} UTC)";
        }

        return msg;
    }

    public static implicit operator string(ApiRateLimit o)
        => o.ToString();
}