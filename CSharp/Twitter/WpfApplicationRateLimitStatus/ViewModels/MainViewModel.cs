// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.IO;
using System.Windows.Input;
using Support.CSharp.Commands;
using Support.CSharp.Json;
using Support.CSharp.Observable;
using WpfApplicationRateLimitStatus.Models;

namespace WpfApplicationRateLimitStatus.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
        => InitializeCommands();

    private const string fileName = "Twitter_ApplicationRateLimitStatus.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    private APIRateStatusModel? result;
    public APIRateStatusModel? Result
    {
        get => result;
        set => Set(ref result, value);
    }

    public ICommand? ClickedCommand { get; private set; }

    private void InitializeCommands()
        => ClickedCommand = new ButtonClickCommand(GetData);

    private void GetData(string buttonName)
    {
        // Retrieve JSON data from file
        string rawJson = File.ReadAllText(Path.Combine(filePath, fileName));

        // Convert to C# Class List of typed objects
        Result = JsonHelper.ToClass<APIRateStatusModel>(rawJson);
    }
}