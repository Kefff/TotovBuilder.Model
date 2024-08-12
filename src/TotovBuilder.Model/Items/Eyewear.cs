﻿using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents eyewear.
    /// </summary>
    public class Eyewear : Item, IEyewear
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double ArmorClass { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("aa")]
        public string[] ArmoredAreas { get; set; } = [];

        /// <inheritdoc/>
        [JsonPropertyName("bi")]
        public string? BaseItemId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("bp")]
        public double BlindnessProtectionPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("dp")]
        public string? DefaultPresetId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("d")]
        public double Durability { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ma")]
        public string Material { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("mo")]
        public ModSlot[] ModSlots { get; set; } = [];

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedModifierPercentage { get; set; }
    }
}
