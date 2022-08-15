// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.ObjectModel;

namespace System;

public static class SystemCollectionsObjectModelExtensions
{
    public static void AddRange<T>(this ObservableCollection<T> host, IEnumerable<T>? data)
    {
        if (data is null || !data.Any())
            return;

        foreach (T item in data)
            host.Add(item);
    }
}