using System.Text.Json.Serialization;

namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the missing properties of an item.
    /// </summary>
    public class ItemMissingProperties
    {
        /// <summary>
        /// ID.
        /// </summary>
        [JsonPropertyName("i")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Maximum number of times the item can be stacked.
        /// </summary>
        [JsonPropertyName("a")]
        public double MaxStackableAmount { get; set; } = 1;
    }
}
