// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class DirectMessagesApiLimits
{
    [JsonPropertyName("/direct_messages")]
    public ApiRateLimit DirectMessages { get; set; }

    [JsonPropertyName("/direct_messages/sent")]
    public ApiRateLimit DirectMessagesSent { get; set; }

    [JsonPropertyName("/direct_messages/sent_and_received")]
    public ApiRateLimit DirectMessagesSentAndReceived { get; set; }

    [JsonPropertyName("/direct_messages/show")]
    public ApiRateLimit DirectMessagesShow { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .Append("DirectMessages: DirectMessages: ").AppendLine(DirectMessages)
            .Append("> Sent: ").AppendLine(DirectMessagesSent)
            .Append("> SentAndReceived: ").AppendLine(DirectMessagesSentAndReceived)
            .Append("> Show: ").AppendLine(DirectMessagesShow);

        return sb.ToString();
    }

    public static implicit operator string(DirectMessagesApiLimits o)
    {
        return o.ToString();
    }
}