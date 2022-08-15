// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using Support.CSharp.Json.Converters;
using WpfMultiSearch.Models;

namespace WpfMultiSearch.JsonConverters;

public sealed class JsonMovieImageUrlConverter : JsonPartialUrlConverter
{
    public JsonMovieImageUrlConverter() : base(Consts.UriPrefix)
    {
        /* skip */
    }
}