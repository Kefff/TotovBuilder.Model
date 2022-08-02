﻿using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a melee weapon.
    /// </summary>
    public class MeleeWeapon : Item, IMeleeWeapon
    {
        /// <inheritdoc/>
        public double ChopDamage { get; set; }

        /// <inheritdoc/>
        public double HitRadius { get; set; }

        /// <inheritdoc/>
        public double StabDamage { get; set; }
    }
}
