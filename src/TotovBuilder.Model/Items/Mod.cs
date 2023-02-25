﻿using System;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a mod.
    /// </summary>
    public class Mod : Item, IMod
    {
        /// <inheritdoc/>
        public string? BaseItemId { get; set; }

        /// <inheritdoc/>
        public string? DefaultPresetId { get; set; }

        /// <inheritdoc/>
        public double ErgonomicsModifier { get; set; }

        /// <inheritdoc/>
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();
    }
}
