// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

namespace WpfFileExplorer.Contracts;

public interface ITVFolder
{
    bool IsExpanded { get; set; }
    bool IsSelected { get; set; }

    string? Name { get; set; }

    void LoadChildren();
}