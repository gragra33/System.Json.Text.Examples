// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WpfPhoto.JsonConverters;

public class JsonFlickrContentConverter<TObject> : JsonConverter<TObject>
{
    public override TObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // position reader

        reader.Read(); // read Property TObject_property
        reader.Read(); // read Property "_content"

        // Get the value of "_content" and convert to the correct type
        TObject? result = (TObject?)Convert.ChangeType(reader.GetString(), GetUnderlyingType());
        
        reader.Read(); // read EndObject for TObject

        return result;
    }

    // converts Generic nullable type to underlying type
    // eg: int? to int
    private Type GetUnderlyingType()
    {
        Type type = typeof(TObject);
        return Nullable.GetUnderlyingType(type) ?? type;
    }

    public override void Write(Utf8JsonWriter writer, TObject? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}