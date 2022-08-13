using System;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a vest.
    /// </summary>
    public class Vest : Item, IVest
    {
        /// <inheritdoc/>
        public double ArmorClass { get; set; }

        /// <inheritdoc/>
        public string[] ArmoredAreas { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        public double Durability { get; set; }

        /// <inheritdoc/>
        public double ErgonomicsPercentageModifier { get; set; }

        /// <inheritdoc/>
        public string Material { get; set; } = string.Empty;

        /// <inheritdoc/>
        public double MovementSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        public string RicochetChance { get; set; } = string.Empty;

        /// <inheritdoc/>
        public double TurningSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        public double Capacity { get; set; }
    }
}
