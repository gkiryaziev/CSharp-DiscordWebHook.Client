using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    public class Footer
    {
        // Sets name for author object. Markdown is disabled here.
        [JsonPropertyName("text")]
        public string Text { get; set; }

        // Sets icon for author object. Requires text value.
        [JsonPropertyName("icon_url")]
        public string IconURL { get; set; }
    }
}
