// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using WpfFileExplorer.Models;

namespace WpfFileExplorer.Contracts;

public interface IFolderDataService
{
    IEnumerable<File> GetChildren(string? parentId);
}