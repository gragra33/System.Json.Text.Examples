// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class AccountApiLimits
{
    [JsonPropertyName("/account/login_verification_enrollment")]
    public ApiRateLimit? AccountLoginVerificationEnrollment { get; set; }

    [JsonPropertyName("/account/update_profile")]
    public ApiRateLimit? AccountUpdateProfile { get; set; }

    [JsonPropertyName("/account/verify_credentials")]
    public ApiRateLimit? AccountVerifyCredentials { get; set; }

    [JsonPropertyName("/account/settings")]
    public ApiRateLimit? AccountSettings { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("Account: LoginVerificationEnrollment: ").AppendLine(AccountLoginVerificationEnrollment!)
            .Append("> UpdateProfile: ").AppendLine(AccountUpdateProfile!)
            .Append("> VerifyCredentials: ").AppendLine(AccountVerifyCredentials!)
            .Append("> Settings: ").AppendLine(AccountSettings!)
            .ToString();

    public static implicit operator string(AccountApiLimits o)
        => o.ToString();
}