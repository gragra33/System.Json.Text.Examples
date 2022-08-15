// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using System.Diagnostics;

namespace WpfUserAgent.Models;

[DebuggerDisplay("{Value}")]
public class ReportLineModel : IReportData
{
    public string? Value { get; set; }
    public List<IReportData>? Items { get; set; }
}