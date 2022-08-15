// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class FavoritesApiLimits
{
    [JsonPropertyName("/favorites/list")]
    public ApiRateLimit FavoritesList { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("Favorites: List: ").AppendLine(FavoritesList);

        return sb.ToString();
    }

    public static implicit operator string(FavoritesApiLimits o)
    {
        return o.ToString();
    }
}