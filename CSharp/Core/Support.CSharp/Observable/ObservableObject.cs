// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Support.CSharp.Observable;

public abstract class ObservableObject : INotifyPropertyChanged
{
    public void Set<TValue>(ref TValue field, TValue newValue, [CallerMemberName] string propertyName = "")
    {
        if (!EqualityComparer<TValue>.Default.Equals(field, default) && field!.Equals(newValue))
            return;

        field = newValue;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}