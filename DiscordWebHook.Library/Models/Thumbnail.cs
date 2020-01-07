using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    public class Thumbnail
    {
        // Allows you to use thumbnail in the embed. You can set only url of the thumbnail.
        [JsonPropertyName("url")]
        public string URL { get; set; }
    }
}
