using System;
using System.Collections.Generic;
using TotovBuilder.Model.Builds;

namespace TotovBuilder.Model.Utils.JsonConverters.Builds
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="InventoryItem"/> class.
    /// </summary>
    public class InventoryItemJsonConverter : ReducedJsonConverter<InventoryItem, InventoryItem>
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<InventoryItem, bool>> GetPropertyExclusionConditions()
        {
            return new Dictionary<string, Func<InventoryItem, bool>>()
            {
                { nameof(InventoryItem.Content), ii => ii.Content.Length == 0 },
                { nameof(InventoryItem.IgnorePrice), ii => !ii.IgnorePrice },
                { nameof(InventoryItem.ModSlots), ii => ii.ModSlots.Length == 0 },
                { nameof(InventoryItem.Quantity), ii => ii.Quantity == 1 }
            };
        }

        /// <inheritdoc/>
        protected override Dictionary<string, Func<InventoryItem, object?>> GetPropertyValueObtentions()
        {
            return new Dictionary<string, Func<InventoryItem, object?>> {
                { nameof(InventoryItem.IgnorePrice), ii => 1 }
            };
        }
    }
}
