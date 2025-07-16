using System.Text.Json.Serialization;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a mod slot.
    /// </summary>
    [JsonConverter(typeof(ModSlotJsonConverter))]
    public class ModSlot
    {
        /// <summary>
        /// IDs of compatible items.
        /// </summary>
        [JsonPropertyName("i")]
        public string[] CompatibleItemIds { get; set; } = [];

        /// <summary>
        /// Maximum number of times the item can be stacked in this mod slot.
        /// Mainly used to force the ammunition quantity to 1 in the special chamber mod slot.
        /// </summary>
        [JsonPropertyName("a")]
        public double MaxStackableAmount { get; set; } = 1;

        /// <summary>
        /// Name.
        /// </summary>
        [JsonPropertyName("n")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Determines whether having an item in the mod slot is required for the parent item to be usable.
        /// </summary>
        [JsonPropertyName("r")]
        public bool Required { get; set; } // TODO : MISSING FROM API
    }
}
