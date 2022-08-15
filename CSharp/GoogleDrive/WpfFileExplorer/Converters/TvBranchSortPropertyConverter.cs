// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace WpfFileExplorer.Converters;

public class TvBranchSortPropertyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        ListCollectionView view = new ListCollectionView((IList)value);
        view.SortDescriptions.Add(new SortDescription(parameter.ToString()!, ListSortDirection.Ascending));
        return view;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotImplementedException();
}