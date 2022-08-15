// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class ContactsApiLimits
{
    [JsonPropertyName("/contacts/addressbook")]
    public ApiRateLimit? ContactsAddressbook { get; set; }

    [JsonPropertyName("/contacts/delete/status")]
    public ApiRateLimit? ContactsDeleteStatus { get; set; }

    [JsonPropertyName("/contacts/uploaded_by")]
    public ApiRateLimit? ContactsUploadedBy { get; set; }

    [JsonPropertyName("/contacts/users")]
    public ApiRateLimit? ContactsUsers { get; set; }

    [JsonPropertyName("/contacts/users_and_uploaded_by")]
    public ApiRateLimit? ContactsUsersAndUploadedBy { get; set; }

    public override string ToString()
        => new StringBuilder()
            .Append("Contacts: Addressbook: ").AppendLine(ContactsAddressbook!)
            .Append("> DeleteStatus: ").AppendLine(ContactsDeleteStatus!)
            .Append("> UploadedBy: ").AppendLine(ContactsUploadedBy!)
            .Append("> Users: ").AppendLine(ContactsUsers!)
            .Append("> UsersAndUploadedBy: ").AppendLine(ContactsUsersAndUploadedBy!)
            .ToString();

    public static implicit operator string(ContactsApiLimits o)
        => o.ToString();
}