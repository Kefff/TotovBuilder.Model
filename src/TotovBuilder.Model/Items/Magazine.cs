using System;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a magazine.
    /// </summary>
    public class Magazine : Item, IMagazine
    {
        /// <inheritdoc/>
        public string[] AcceptedAmmunitionIds { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        public double CheckSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        public bool IsPreset { get; set; }

        /// <inheritdoc/>
        public double LoadSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        public double MalfunctionPercentage { get; set; }

        /// <inheritdoc/>
        public double Capacity { get; set; }

        /// <inheritdoc/>
        public double ErgonomicsModifier { get; set; }

        /// <inheritdoc/>
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();
    }
}
