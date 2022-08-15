// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WpfPhoto.JsonConverters;

public class JsonFlickrUnixDateContentConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // position reader

        reader.Read(); // read Property TObject_property
        reader.Read(); // read Property "_content"

        // Get the value of "_content"and convert to the correct type
        DateTime? result = reader.GetDouble().FromUnixDate();
        
        reader.Read(); // read EndObject for TObject

        return result;
    }

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}