// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using Support.CSharp.Json;
using WpfFileExplorer.Contracts;
using WpfFileExplorer.JsonConverters;
using WpfFileExplorer.Models;
using IO = System.IO;

namespace WpfFileExplorer.DataServices;

public class GoogleDriveDataService : IFolderDataService
{
    public GoogleDriveDataService(string path, string fileTemplate)
    {
        filePath = path;
        this.fileTemplate = fileTemplate;
    }

    private readonly string filePath;
    private readonly string fileTemplate;

    public IEnumerable<File> GetChildren(string? parentId)
    {
        // Retrieve JSON data from file
        string fileName = IO.Path.Combine(filePath, string.Format(fileTemplate, parentId));

        if (!IO.File.Exists(fileName)) yield break;

        string rawJson = IO.File.ReadAllText(fileName);

        // Convert to C# Class List of typed objects
        FileList? results = JsonHelper.ToClass<FileList>(rawJson, JsonSerializerConfiguration.Options);

        if (results?.Files is null)
            yield break;

        foreach (File file in results.Files!)
            yield return file;
    }
}