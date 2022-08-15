// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;

namespace WpfUserAgent.Models;

public class PluginModel
{
    public string? Id { get; set; }
    public List<PluginObjectModel>? Values { get; set; }
}