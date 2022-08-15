// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using WpfFileExplorer.Contracts;

namespace WpfFileExplorer.ViewModels;

public abstract class FolderViewModelBase : TvViewModelBase, INodeFolder
{
    #region Constructor

    public FolderViewModelBase(ITVFolder? parent, bool lazyLoadChildren) : base(parent, lazyLoadChildren) { /* skip */ }

    #endregion

    #region Properties

    private string? id;
    public string? Id
    {
        get => id;
        set => Set(ref id, value);
    }

    #endregion
}