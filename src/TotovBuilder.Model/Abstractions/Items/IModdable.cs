using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of a moddable item.
    /// </summary>
    public interface IModdable : IItem
    {
        /// <summary>
        /// Mod slots.
        /// </summary>
        ModSlot[] ModSlots { get; set; }
    }
}
