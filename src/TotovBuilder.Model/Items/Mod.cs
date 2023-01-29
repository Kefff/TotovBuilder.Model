using System;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a mod.
    /// </summary>
    public class Mod : Item, IMod
    {
        /// <inheritdoc/>
        public double ErgonomicsModifier { get; set; }

        /// <inheritdoc/>
        public bool IsPreset { get; set; }

        /// <inheritdoc/>
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();
    }
}
