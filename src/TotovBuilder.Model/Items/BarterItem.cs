using System.Text.Json.Serialization;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a barter item.
    /// </summary>
    public class BarterItem
    {
        /// <summary>
        /// ID.
        /// </summary>
        [JsonPropertyName("i")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// Quantity.
        /// </summary>
        [JsonPropertyName("q")]
        public double Quantity { get; set; }
    }
}
