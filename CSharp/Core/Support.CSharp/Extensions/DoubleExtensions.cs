// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

namespace System;

public static class DoubleExtensions
{
    public static DateTime FromUnixDate(this double? unixDate)
        => Unix.Epoch.AddSeconds(unixDate ?? 0.0);

    public static DateTime FromUnixDate(this double unixDate)
        => Unix.Epoch.AddSeconds(unixDate);
}