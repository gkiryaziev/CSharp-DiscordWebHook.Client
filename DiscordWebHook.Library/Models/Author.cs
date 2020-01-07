using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    public class Author
    {
        // Sets name of author.
        [JsonPropertyName("name")]
        public string Name { get; set; }

        // Sets link. Requires name value. If used, transforms name into hyperlink.
        [JsonPropertyName("url")]
        public string URL { get; set; }

        // Sets avatar. Requires name value.
        [JsonPropertyName("icon_url")]
        public string IconURL { get; set; }
    }
}
