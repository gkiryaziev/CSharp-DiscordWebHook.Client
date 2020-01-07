using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    // Webhooks structure. All elements listed here are optional but the minimal requirement is
    // non-empty 'Content' or 'Embeds' fields.
    // Structure of Webhook https://birdie0.github.io/discord-webhooks-guide/discord_webhook.html
    public class WebHookMessage
    {
        // Overrides webhook's username. Useful, if you're using same webhook url for several things.
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        // Overrides webhook's avatar. Useful, if you're using same webhook url for several things.
        [JsonPropertyName("avatar_url")]
        public string AvatarURL { get; set; }

        // Sets text for webhook message.
        [JsonPropertyName("content")]
        public string Content { get; set; }

        // Adds embeds to webhook message. embeds is an array of embeds and can contain up to 10 embeds in the same message.
        [JsonPropertyName("embeds")]
        public List<Embed> Embeds { get; set; }

        // Enables text-to-speech for current message, so everyone who have tts enabled with hear it.
        [JsonPropertyName("tts")]
        public bool TTS { get; set; }
    }
}
