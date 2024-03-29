﻿namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of an armor.
    /// </summary>
    public interface IArmor : IWearable
    {
        /// <summary>
        /// Armor class.
        /// </summary>
        double ArmorClass { get; set; }

        /// <summary>
        /// List of areas protected by the armor.
        /// </summary>
        string[] ArmoredAreas { get; set; }

        /// <summary>
        /// Durability
        /// </summary>
        double Durability { get; set; }

        /// <summary>
        /// Material which composes the armor.
        /// </summary>
        string Material { get; set; }

        /// <summary>
        /// Chance of ricochet.
        /// </summary>
        string RicochetChance { get; set; }
    }
}
