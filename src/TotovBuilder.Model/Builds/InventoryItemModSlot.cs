using System.Text.Json.Serialization;

namespace TotovBuilder.Model.Builds
{
    /// <summary>
    /// Represents a mod slot in an inventory item.
    /// </summary>
    public class InventoryItemModSlot
    {
        /// <summary>
        /// Item.
        /// </summary>
        [JsonPropertyName("i")]
        public InventoryItem? Item { get; set; }

        /// <summary>
        /// Name of the mod slot.
        /// </summary>
        [JsonPropertyName("n")]
        public string ModSlotName { get; set; } = string.Empty;
    }
}
