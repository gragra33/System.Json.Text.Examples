// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.ObjectModel;
using Support.CSharp.Observable;
using WpfFileExplorer.Contracts;
using WpfFileExplorer.DataServices;

namespace WpfFileExplorer.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        Folders = new ObservableCollection<ITVFolder>();
        GetData();
    }

    private const string fileNameTemplate = "GoogleDrive_{0}.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    public ObservableCollection<ITVFolder> Folders { get; }

    private void GetData()
    {
        GoogleDriveDataService dataService = new GoogleDriveDataService(filePath, fileNameTemplate);
        GoogleDriveFolderViewModel folder = new GoogleDriveFolderViewModel(null, true, dataService)
        {
            Id = "Root",
            Name = "My Drive"
        };

        Folders.Add(folder);
    }
}