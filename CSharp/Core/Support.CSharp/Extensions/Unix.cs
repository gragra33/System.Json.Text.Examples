// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

namespace System;

internal static class Unix
{
    internal static readonly DateTime Epoch = new(
        year: 1970, month: 1, day: 1,
        hour: 0, minute: 0, second: 0, millisecond: 0,
        kind: DateTimeKind.Utc);
}