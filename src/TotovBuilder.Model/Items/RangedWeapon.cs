using System;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a ranged weapon.
    /// </summary>
    public class RangedWeapon : Item, IRangedWeapon
    {
        /// <inheritdoc/>
        public string Caliber { get; set; } = string.Empty;

        /// <inheritdoc/>
        public string DefaultPresetId { get; set; } = string.Empty;

        /// <inheritdoc/>
        public double Ergonomics { get; set; }

        /// <inheritdoc/>
        public string[] FireModes { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        public double FireRate { get; set; }

        /// <inheritdoc/>
        public double HorizontalRecoil { get; set; }

        /// <inheritdoc/>
        public double VerticalRecoil { get; set; }

        /// <inheritdoc/>
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();
    }
}
