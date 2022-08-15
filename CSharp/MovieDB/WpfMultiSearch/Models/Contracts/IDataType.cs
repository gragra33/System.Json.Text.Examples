// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

namespace WpfMultiSearch.Models;

public interface IDataType
{
    string? MediaType { get; set; }
}