// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Diagnostics;
using Support.CSharp.Observable;

namespace WpfApplicationRateLimitStatus.Models;

[DebuggerDisplay("Name: {Name}")]
public class RateLimitModel : ObservableObject
{
    private string name;
    public string Name
    {
        get => name;
        set => Set(ref name, value);
    }

    private ApiRateLimitModel limit;
    public ApiRateLimitModel Limit
    {
        get => limit;
        set => Set(ref limit, value);
    }
}