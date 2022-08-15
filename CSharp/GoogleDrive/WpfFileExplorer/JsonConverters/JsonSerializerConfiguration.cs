// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json;
using Support.CSharp.Json.Converters;

namespace WpfFileExplorer.JsonConverters;

public static class JsonSerializerConfiguration
{
    public static readonly JsonSerializerOptions Options = new()
    {
        // some numbers in the json are string. We want to auto-convert to the correct types
        NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString,

        // use custom converter as Flickr uses '0' & '1' for bool values
        Converters = { new JsonStringBoolConverter() },
    };
}