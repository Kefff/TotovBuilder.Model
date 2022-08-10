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
        /// IDs of accepted ammunition for magazines.
        /// </summary>
        public string[] AcceptedAmmunitionIds { get; set; } = Array.Empty<string>();

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
        /// Mod slots for moddable items.
        /// </summary>
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();

        /// <summary>
        /// Value of the X parameter for ricochet chances.
        /// </summary>
        public double? RicochetXValue { get; set; }
    }
}
