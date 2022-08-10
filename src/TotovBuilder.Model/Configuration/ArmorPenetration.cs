using System;

namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents an armor penetration
    /// </summary>
    public class ArmorPenetration
    {
        /// <summary>
        /// Ammunition ID.
        /// </summary>
        public string AmmunitionId { get; set; } = string.Empty;

        /// <summary>
        /// Ammunition name.
        /// </summary>
        public string AmmunitionName { get; set; } = string.Empty;

        /// <summary>
        /// Armor penetration values.
        /// </summary>
        public double[] Values { get; set; } = Array.Empty<double>();
    }
}
