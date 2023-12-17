using System.Text.Json.Serialization;

namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents a quest.
    /// </summary>
    public class Quest
    {
        /// <summary>
        /// ID.
        /// </summary>
        [JsonPropertyName("i")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Name.
        /// </summary>
        [JsonPropertyName("n")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Wiki link.
        /// </summary>
        [JsonPropertyName("w")]
        public string WikiLink { get; set; } = string.Empty;
    }
}
