// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.ObjectModel;
using Support.CSharp.Observable;
using WpfFileExplorer.Contracts;

namespace WpfFileExplorer.ViewModels;

public abstract class TvViewModelBase : ViewModelBase, ITVFolder
{
    #region Constructor

    protected TvViewModelBase(ITVFolder? parent, bool lazyLoadChildren)
    {
        this.parent = parent;

        Children = new ObservableCollection<ITVFolder>();

        if (lazyLoadChildren)
            Children.Add(DummyChild);
    }

    private TvViewModelBase() { /* skip */ }

    #endregion

    #region Properties

    private static readonly ITVFolder DummyChild = new DummyViewModel();

    public ObservableCollection<ITVFolder> Children { get; }

    private bool isExpanded;
    public bool IsExpanded
    {
        get => isExpanded;
        set
        {
            Set(ref isExpanded, value);
            ExecuteExpand();
        }
    }

    private bool isSelected;
    public bool IsSelected
    {
        get => isSelected;
        set => Set(ref isSelected, value);
    }

    private readonly ITVFolder? parent;
    public ITVFolder? Parent => parent;

    private bool HasDummyChild
        => Children.Count == 1 && Children[0] == DummyChild;

    private string? name;
    public string? Name
    {
        get => name;
        set => Set(ref name, value);
    }

    #endregion

    #region Methods

    private void ExecuteExpand()
    {
        // Expand all the way up to the root.
        if (isExpanded && parent is not null)
            parent.IsExpanded = true;

        // Lazy load the child items, if necessary.
        if (HasDummyChild)
        {
            Children.Remove(DummyChild);
            LoadChildren();
        }
    }

    public abstract void LoadChildren();

    #endregion

    private class DummyViewModel : TvViewModelBase
    {
        public override void LoadChildren() { }
    }
}