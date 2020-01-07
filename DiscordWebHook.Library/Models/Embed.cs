using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    public class Embed
    {
        // Sets color for webhook's embed. It equals 0 (transparent) by default. Color requires number instead hex code
        [JsonPropertyName("color")]
        public int Color { get; set; }

        // Adds Author block to embed.
        [JsonPropertyName("author")]
        public Author Author { get; set; }

        // Sets title for webhook's embed.
        [JsonPropertyName("title")]
        public string Title { get; set; }

        // Sets link for title in your webhook message. Requires title variable and turns it into hyperlink.
        [JsonPropertyName("url")]
        public string URL { get; set; }

        // Sets description for webhook's embed.
        [JsonPropertyName("description")]
        public string Description { get; set; }

        // Allows you to use multiple title + description blocks in embed. fields is an array of field objects.
        // You can use up to 25 fields in same embed. name and value support Discord Markdown.
        // https://birdie0.github.io/discord-webhooks-guide/markdown.md
        [JsonPropertyName("fields")]
        public List<Field> Fields { get; set; }

        // Allows you to use image in the embed.
        [JsonPropertyName("image")]
        public Image Image { get; set; }

        // Allows you to use thumbnail in the embed.
        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        // Allows you to add footer to embed.
        [JsonPropertyName("footer")]
        public Footer Footer { get; set; }

        // Allows you to add ISO8601 timestamp to embed. Time stores as String in the next format: "YYYY-MM-DDTHH:MM:SS.MSSZ".
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
