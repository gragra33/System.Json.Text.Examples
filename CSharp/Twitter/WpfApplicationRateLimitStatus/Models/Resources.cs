// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Text.Json.Serialization;
using System.Text;

namespace WpfApplicationRateLimitStatus.Models;

public class Resources
{
    [JsonPropertyName("account")]
    public AccountApiLimits Account { get; set; }

    [JsonPropertyName("application")]
    public ApplicationApiLimits Application { get; set; }

    [JsonPropertyName("auth")]
    public AuthApiLimits Auth { get; set; }

    [JsonPropertyName("blocks")]
    public BlocksApiLimits Blocks { get; set; }

    [JsonPropertyName("business_experience")]
    public BusinessExperienceApiLimits BusinessExperience { get; set; }

    [JsonPropertyName("collections")]
    public CollectionsApiLimits Collections { get; set; }

    [JsonPropertyName("contacts")]
    public ContactsApiLimits Contacts { get; set; }

    [JsonPropertyName("custom_profiles")]
    public CustomProfilesApiLimits CustomProfiles { get; set; }

    [JsonPropertyName("device")]
    public DeviceApiLimits Device { get; set; }

    [JsonPropertyName("direct_messages")]
    public DirectMessagesApiLimits DirectMessages { get; set; }

    [JsonPropertyName("drafts")]
    public DraftsApiLimits Drafts { get; set; }

    [JsonPropertyName("favorites")]
    public FavoritesApiLimits Favorites { get; set; }

    [JsonPropertyName("feedback")]
    public FeedbackApiLimits Feedback { get; set; }

    [JsonPropertyName("followers")]
    public FollowersApiLimits Followers { get; set; }

    [JsonPropertyName("friends")]
    public FriendsApiLimits Friends { get; set; }

    [JsonPropertyName("friendships")]
    public FriendshipsApiLimits Friendships { get; set; }

    [JsonPropertyName("geo")]
    public GeoApiLimits Geo { get; set; }

    [JsonPropertyName("help")]
    public HelpApiLimits Help { get; set; }

    [JsonPropertyName("lists")]
    public ListsApiLimits Lists { get; set; }

    [JsonPropertyName("live_pipeline")]
    public LivePipelineApiLimits LivePipeline { get; set; }

    [JsonPropertyName("live_video_stream")]
    public LiveVideoStreamApiLimits LiveVideoStream { get; set; }

    [JsonPropertyName("media")]
    public MediaApiLimits Media { get; set; }

    [JsonPropertyName("moments")]
    public MomentsApiLimits Moments { get; set; }

    [JsonPropertyName("mutes")]
    public MutesApiLimits Mutes { get; set; }

    [JsonPropertyName("saved_searches")]
    public SavedSearchesApiLimits SavedSearches { get; set; }

    [JsonPropertyName("search")]
    public SearchApiLimits Search { get; set; }

    [JsonPropertyName("statuses")]
    public StatusesApiLimits Statuses { get; set; }

    [JsonPropertyName("trends")]
    public TrendsApiLimits Trends { get; set; }

    [JsonPropertyName("tweet_prompts")]
    public TweetPromptsApiLimits TweetPrompts { get; set; }

    [JsonPropertyName("users")]
    public UsersApiLimits Users { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder()
            .AppendLine(Account)
            .AppendLine(Application)
            .AppendLine(Auth)
            .AppendLine(Blocks)
            .AppendLine(BusinessExperience)
            .AppendLine(Collections)
            .AppendLine(Contacts)
            .AppendLine(CustomProfiles)
            .AppendLine(Device)
            .AppendLine(DirectMessages)
            .AppendLine(Drafts)
            .AppendLine(Favorites)
            .AppendLine(Feedback)
            .AppendLine(Followers)
            .AppendLine(Friends)
            .AppendLine(Friendships)
            .AppendLine(Geo)
            .AppendLine(Help)
            .AppendLine(Lists)
            .AppendLine(LivePipeline)
            .AppendLine(LiveVideoStream)
            .AppendLine(Media)
            .AppendLine(Moments)
            .AppendLine(Mutes)
            .AppendLine(SavedSearches)
            .AppendLine(Search)
            .AppendLine(Statuses)
            .AppendLine(Trends)
            .AppendLine(TweetPrompts)
            .AppendLine(Users);

        return sb.ToString();
    }

    public static implicit operator string(Resources o)
    {
        return o.ToString();
    }
}