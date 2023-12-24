using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Utils;

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

    /// <summary>
    /// Represents a JSON converter for the <see cref="InventoryItem"/> class.
    /// </summary>
    public class InventoryItemJsonConverter : ReducedSerializationBaseConverter<InventoryItem>
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<InventoryItem, bool>> PropertyExclusionConditions
        {
            get { return _propertyExclusionConditions; }
        }
        private readonly Dictionary<string, Func<InventoryItem, bool>> _propertyExclusionConditions = new Dictionary<string, Func<InventoryItem, bool>>()
        {
            { nameof(InventoryItem.Content), ii => ii.Content.Length == 0 },
            { nameof(InventoryItem.IgnorePrice), ii => !ii.IgnorePrice },
            { nameof(InventoryItem.ModSlots), ii => ii.ModSlots.Length == 0 },
            { nameof(InventoryItem.Quantity), ii => ii.Quantity == 1 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<InventoryItem, object?>> PropertyValuesObtentions
        {
            get { return _propertyValuesObtentions; }
        }
        private readonly Dictionary<string, Func<InventoryItem, object?>> _propertyValuesObtentions = new Dictionary<string, Func<InventoryItem, object?>>()
        {
            { nameof(InventoryItem.IgnorePrice), ii => string.Empty }
        };
    }
}
