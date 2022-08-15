// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfFileExplorer.Contracts;
using WpfFileExplorer.Models;

namespace WpfFileExplorer.ViewModels;

public class GoogleDriveFolderViewModel : FolderViewModelBase
{
    public GoogleDriveFolderViewModel(INodeFolder? parent, bool lazyLoadChildren, IFolderDataService service)
        : base(parent, lazyLoadChildren)
    {
        Files = new ObservableCollection<IResourceKind>();
        this.service = service;
    }

    private readonly IFolderDataService service;

    public override void LoadChildren()
    {
        IEnumerable<File> data = service.GetChildren(Id);
        if (data.Any())
        {
            Files.AddRange(data);
            foreach (File folder in data.Where(x => x.GetType() == typeof(Folder)))
            {
                Children.Add(new GoogleDriveFolderViewModel(this, true, service)
                {
                    Id = folder.Id,
                    Name = folder.Name
                });
            }
        }
    }

    public ObservableCollection<IResourceKind> Files { get; }
}