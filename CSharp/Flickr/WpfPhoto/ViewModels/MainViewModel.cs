// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.IO;
using System.Windows.Input;
using Support.CSharp.Commands;
using Support.CSharp.Json;
using Support.CSharp.Observable;
using WpfPhoto.JsonConverters;
using WpfPhoto.Models;

namespace WpfPhoto.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
        => InitializeCommands();

    private Photo? result;

    public Photo? Result
    {
        get => result;
        private set => Set(ref result, value);
    }

    public ICommand? ClickedCommand { get; private set; }

    private void InitializeCommands()
        => ClickedCommand = new ButtonClickCommand(GetData);

    private const string fileName = "Flickr_Photo.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    private void GetData(string buttonName)
    {
        // Retrieve JSON data from file
        string rawJson = File.ReadAllText(Path.Combine(filePath, fileName));

        // Convert to C# Class typed object
        PhotoResponse? response = JsonHelper.ToClass<PhotoResponse>(rawJson, JsonSerializerConfiguration.Options);
       
        if (response?.Photo is not null)
            Result = response.Photo;
    }
}