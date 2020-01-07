using System.Text.Json.Serialization;

namespace DiscordWebHook.Library.Models
{
    public class Field
    {
        // Sets name for field object. Required.
        [JsonPropertyName("name")]
        public string Name { get; set; }

        // Sets description for field object. Required.
        [JsonPropertyName("value")]
        public string Value { get; set; }

        // If true, fields will be displayed in the same line,
        // but there can only be 3 max in the same line or 2 max if you used thumbnail. Optional.
        [JsonPropertyName("inline")]
        public bool Inline { get; set; }
    }
}
