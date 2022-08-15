// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class AuthApiLimits
{
    [JsonPropertyName("/auth/csrf_token")]
    public ApiRateLimit? AuthCsrfToken { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("Auth: CsrfToken: ").AppendLine(AuthCsrfToken!)
            .ToString();

    public static implicit operator string(AuthApiLimits o)
        => o.ToString();
}