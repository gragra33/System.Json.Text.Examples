// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Windows.Media;

namespace System.Windows.Controls;

public static class TreeViewItemExtensions
{
    public static int GetDepth(this TreeViewItem item)
    {
        while (GetParent(item) is { } parent)
            return GetDepth(parent) + 1;

        return 0;
    }

    private static TreeViewItem GetParent(TreeViewItem item)
    {
        DependencyObject? parent = VisualTreeHelper.GetParent(item);

        while (!(parent is TreeViewItem || parent is TreeView))
        {
            parent = VisualTreeHelper.GetParent(parent!);
        }
        return (parent as TreeViewItem)!;
    }
}