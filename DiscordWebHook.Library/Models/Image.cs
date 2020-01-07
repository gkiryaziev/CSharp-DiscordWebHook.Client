using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    public class Image
    {
        // Allows you to use image in the embed. You can set only url of the image.
        [JsonPropertyName("url")]
        public string URL { get; set; }
    }
}
