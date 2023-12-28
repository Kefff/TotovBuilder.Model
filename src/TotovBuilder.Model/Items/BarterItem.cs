using System.Text.Json.Serialization;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a barter item.
    /// </summary>
    [JsonConverter(typeof(BarterItemJsonConverter))]
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
