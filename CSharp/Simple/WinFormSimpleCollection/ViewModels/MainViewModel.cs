// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.ComponentModel;
using Support.CSharp.Json;
using WinFormSimpleCollection.Models;

namespace WinFormSimpleCollection.ViewModels;

public class MainViewModel
{
    private const string fileName = "Etsy_Categories.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    public BindingList<Category> Categories { get; } = new();

    public void HandleClicked() => GetData();

    private void GetData()
    {
        // Retrieve JSON data from file
        string rawJson = File.ReadAllText(Path.Combine(filePath, fileName));

        // Convert to C# Class typed object
        Response<Category>? response = JsonHelper.ToClass<Response<Category>>(rawJson);

        // Get collection of objects
        if (response is { Results.Count: > 0 })
        {
            IList<Category>? data = response.Results;

            Categories.Clear();

            for (int i = 0; i < data.Count; i++)
                Categories.Add(data[i]);
        }
    }
}