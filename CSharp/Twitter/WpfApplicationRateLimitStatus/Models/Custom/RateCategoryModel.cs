// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.ObjectModel;
using System.Diagnostics;
using Support.CSharp.Observable;

namespace WpfApplicationRateLimitStatus.Models;

[DebuggerDisplay("Name: {Name}")]
public class RateCategoryModel : ObservableObject
{
    public RateCategoryModel()
    {
        Limits = new ObservableCollection<RateLimitModel>();
    }

    private string name;
    public string Name
    {
        get => name;
        set => Set(ref name, value);
    }

    public ObservableCollection<RateLimitModel> Limits { get; private set; }
}