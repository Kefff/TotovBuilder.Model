using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Utils.JsonConverters.Builds;

namespace TotovBuilder.Model.Builds
{
    /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    [JsonConverter(typeof(InventoryItemJsonConverter))]
    public class InventoryItem
    {
        /// <summary>
        /// Items contained in the item.
        /// </summary>
        [JsonPropertyName("c")]
        public InventoryItem[] Content { get; set; } = Array.Empty<InventoryItem>();

        /// <summary>
        /// Indicates whether the price of the item is used or not.
        /// When undefined, the price is taken in consideration.
        /// </summary>
        [JsonPropertyName("p")]
        public bool IgnorePrice { get; set; } = false;

        /// <summary>
        /// Item ID.
        /// </summary>
        [JsonPropertyName("i")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// Mods slots.
        /// </summary>
        [JsonPropertyName("m")]
        public InventoryItemModSlot[] ModSlots { get; set; } = Array.Empty<InventoryItemModSlot>();

        /// <summary>
        /// Number of items stacked.
        /// </summary>
        [JsonPropertyName("q")]
        public double Quantity { get; set; } = 1;
    }
}
