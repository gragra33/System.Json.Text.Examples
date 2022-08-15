// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.IO;
using System.Windows.Input;
using Support.CSharp.Commands;
using Support.CSharp.Json;
using Support.CSharp.Observable;
using WpfMultiSearch.JsonConverters;
using WpfMultiSearch.Models;

namespace WpfMultiSearch.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
        => InitializeCommands();

    private const string fileName = "MovieDB_MultiSearch.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    private Response? results;
    public Response? Results
    {
        get => results;
        set => Set(ref results, value);
    }

    public ICommand? ClickedCommand { get; private set; }

    private void InitializeCommands()
        => ClickedCommand = new ButtonClickCommand(GetData);

    private void GetData(string buttonName)
    {
        // Retrieve JSON data from file
        string rawJson = File.ReadAllText(Path.Combine(filePath, fileName));

        // Convert to C# Class List of typed objects
        Results = JsonHelper.ToClass<Response>(rawJson, JsonSerializerConfiguration.Options);
    }
}