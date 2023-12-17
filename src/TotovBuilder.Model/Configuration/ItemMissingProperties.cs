using System;
using System.Text.Json.Serialization;
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
        [JsonPropertyName("c")]
        public string[] ConflictingItemIds { get; set; } = Array.Empty<string>();

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

        /// <summary>
        /// Ranged weapon chambers.
        /// </summary>
        [JsonPropertyName("ch")]
        public ModSlot[] RangedWeaponChambers { get; set; } = Array.Empty<ModSlot>();
    }
}
