using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of a moddable item.
    /// </summary>
    public interface IModdable : IItem
    {
        /// <summary>
        /// ID of the base item when the item is a preset.
        /// </summary>
        string? BaseItemId { get; set; }

        /// <summary>
        /// ID of the default preset.
        /// </summary>
        string? DefaultPresetId { get; set; }

        /// <summary>
        /// Mod slots.
        /// </summary>
        ModSlot[] ModSlots { get; set; }
    }
}
