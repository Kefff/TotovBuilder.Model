using System;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the missing properties of an item.
    /// </summary>
    public class ItemMissingProperties
    {
        /// <summary>
        /// IDs of conflicting items.
        /// </summary>
        public string[] ConflictingItemIds { get; set; } = Array.Empty<string>();

        /// <summary>
        /// ID.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Maximum number of times the item can be stacked.
        /// </summary>
        public double MaxStackableAmount { get; set; } = 1;

        /// <summary>
        /// Ranged weapon chambers.
        /// </summary>
        public ModSlot[] RangedWeaponChambers { get; set; } = Array.Empty<ModSlot>();
    }
}
