// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Support.CSharp.Json;
using WpfFileExplorer.Models;

namespace WpfFileExplorer.JsonConverters;

public static class MimeToFileConverter
{
    // polymorphic deserialization
    // only some types are lists for briefity
    public static readonly Dictionary<string, Func<JsonObject, File>> Types = new()
    {
        { "application/vnd.google-apps.folder", Convert<Folder>()! },
        { "image/jpeg", Convert<JpgImage>()! },
        { "image/png", Convert<PngImage>()! },
        { "application/zip", Convert<Zipped>()! },
        { "application/x-zip-compressed", Convert<Zipped>()! },
        { "video/mp4", Convert<Mp4Video>()! },
        { "text/plain", Convert<TxtDocument>()! },
        { "application/vnd.openxmlformats-officedocument.presentationml.presentation", Convert<PptDocument>()! },
        { "application/vnd.openxmlformats-officedocument.wordprocessingml.document", Convert<WordDocument>()! }
    };
    
    // Convert Json Object data into a specified class type
    private static Func<JsonObject, File?> Convert<TModel>() where TModel : File
        => jsonObject => JsonHelper.ToClass<TModel>(jsonObject.ToString(), JsonSerializerConfiguration.Options);
}