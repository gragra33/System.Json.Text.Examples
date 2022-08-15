// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Diagnostics;

namespace WpfUserAgent.Models;

[DebuggerDisplay("{Key} = {Value}")]
public class ReportLineItemModel : IReportData
{
    public string? Key { get; set; }
    public string? Value { get; set; }
}