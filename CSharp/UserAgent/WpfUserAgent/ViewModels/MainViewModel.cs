// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using Support.CSharp.Commands;
using Support.CSharp.Json;
using Support.CSharp.Observable;
using WpfUserAgent.Extensions;
using WpfUserAgent.Models;

namespace WpfUserAgent.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
        => InitializeCommands();

    private const string fileName = "UserAgent.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    private ObservableCollection<IReportData>? report;
    public ObservableCollection<IReportData>? Report
    {
        get => report;
        set => Set(ref report, value);
    }

    public ICommand? ClickedCommand { get; private set; }

    private void InitializeCommands()
        => ClickedCommand = new ButtonClickCommand(GetData);

    private void GetData(string buttonName)
    {
        // Retrieve JSON data from file
        string rawJson = File.ReadAllText(Path.Combine(filePath, fileName));

        // Convert to C# Class List of typed objects
        UserAgentModel? result = JsonHelper.ToClass<UserAgentModel>(rawJson);

        GenerateReport(result);
    }

    private void GenerateReport(UserAgentModel? model)
    {
        if (Report is null)
            Report = new ObservableCollection<IReportData>();
        else
            Report.Clear();

        foreach (PropertyInfo prop in model?.GetType().GetProperties().OrderBy(x => x.Name)!)
        {
            switch (prop.Name)
            {
                case "Languages":
                    Report.Add(model.GetLanguage(prop.Name));
                    break;

                case "UserAgentData":
                    Report.Add(model.GetUserAgentData(prop.Name));
                    break;

                case "Plugins":
                    Report.Add(model.GetPlugins(prop.Name));
                    break;

                case "MimeTypes":
                    // not implemented
                    break;

                default:
                    string? value = prop.GetValue(model, null)?.ToString();
                    if (!string.IsNullOrWhiteSpace(value))
                        Report.Add(new ReportLineItemModel
                        {
                            Key = prop.Name,
                            Value = prop.GetValue(model, null)?.ToString()
                        });
                    break;
            }
        }
    }
}